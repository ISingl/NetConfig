using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetConfig
{
    public partial class Form1 : Form
    {
        List<string> currentIP = new List<string>();

        public Form1()
        {
            InitializeComponent();
            this.Text += GetAndDisplayRights();
            GetConfigEthernet();            
        }

        private string GetAndDisplayRights()
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            return hasAdministrativeRight ? "(Running with full rights)" : "(Running with limited rights)";
        }

        private void GetConfigEthernet()
        {
            currentIP.Clear();
            comboBox1.Items.Clear();
            string[] temp = null;
            temp = GetProcessCMD("/c netsh interface ipv4 show config name=\"Ethernet\"");

            if (temp == null)
                return;

            string data;
            for (int i = 0; i < temp.Length; i++)
            {

                if (temp[i].Contains("DHCP включен"))
                {
                    labelDHCP.Text = temp[i].Split(':')[1].Trim();
                }
                if (temp[i].Contains("IP-адрес"))
                {
                    data = temp[i].Split('с')[1].Trim() + "&";
                    data += temp[i + 1].Split(':')[1].Trim();
                    currentIP.Add(data);
                }
            }

            foreach (string curr in currentIP)
            {
                comboBox1.Items.Add(curr.Split('&')[0]);
            }
            if (comboBox1.Items.Count != 0)
                comboBox1.SelectedIndex = 0;
            if (labelDHCP.Text == "Нет")
            {
                groupBox2.Enabled = true;
                btnDeleteIp.Enabled = true;
                comboBox1.Enabled = true;
            }
            if (labelDHCP.Text == "Да")
            {
                groupBox2.Enabled = false;
                btnDeleteIp.Enabled = false;
                comboBox1.Enabled = false;
                label5.Text = "unknown";
            }
        }

        private static string[] GetProcessCMD(string argument)
        {
            string[] temp = null;
            try
            {
                Process processCmd = new Process();
                processCmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processCmd.StartInfo.UseShellExecute = false;
                processCmd.StartInfo.RedirectStandardOutput = true;
                processCmd.StartInfo.CreateNoWindow = true;
                processCmd.StartInfo.FileName = "cmd.exe";
                processCmd.StartInfo.Arguments = argument;
                processCmd.StartInfo.StandardOutputEncoding = Encoding.GetEncoding(866);
                processCmd.Start();
                StreamReader srIncoming = processCmd.StandardOutput;
                temp = srIncoming.ReadToEnd().Split('\n');
                processCmd.WaitForExit();
            }
            catch (Win32Exception) { }

            return temp;
        }

        private static void SetProcessCMD(string argument)
        {
            try
            {
                Process processCmd = new Process();
                processCmd.StartInfo.Verb = "runas";
                processCmd.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processCmd.StartInfo.CreateNoWindow = true;
                processCmd.StartInfo.FileName = "cmd.exe";
                processCmd.StartInfo.Arguments = argument;
                processCmd.Start();
                processCmd.WaitForExit();
            }
            catch (Win32Exception) { }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SetProcessCMD("/c netsh interface ipv4 set address name=\"Ethernet\" source=dhcp");
            //Thread.Sleep(4000);
            //GetConfigEthernet();
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = currentIP[comboBox1.SelectedIndex].Split('&')[1];
        }

        private void BtnAddIp_Click(object sender, EventArgs e)
        {
            if (txtIp.Text == "" || txtMask.Text == "")
            {
                MessageBox.Show("Нет данных", "Ошибка");
                return;
            }

            SetProcessCMD("/c netsh interface ipv4 add address \"Ethernet\" " + txtIp.Text+ " " + txtMask.Text);

            txtIp.Text = "";
            txtMask.Text = "";
            //Thread.Sleep(4000);

            timer1.Enabled = true;
        }

        private void BtnDeleteIp_Click(object sender, EventArgs e)
        {
            SetProcessCMD("/c netsh interface ipv4 delete address \"Ethernet\" " + comboBox1.Items[comboBox1.SelectedIndex].ToString().Split('&')[0]);
            GetConfigEthernet();
            SaveToFile();
        }

        private void SaveToFile()
        {
            if(!File.Exists(Directory.GetCurrentDirectory() + "/IP.txt"))
            {
                MessageBox.Show("Файл с конфигурацией не найден", "Ошибка");
                return;
            }

            try
            {
                File.WriteAllLines(Directory.GetCurrentDirectory() + "/IP.txt", currentIP);
            }
            catch (Win32Exception) { }
        }

        private void BtnStatic_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Directory.GetCurrentDirectory() + "/IP.txt"))
            {
                MessageBox.Show("Файл с конфигурацией не найден", "Ошибка");
                return;
            }

            try
            {
                currentIP.Clear();
                currentIP.AddRange(File.ReadAllLines(Directory.GetCurrentDirectory() + "/IP.txt"));
                string tmp;
                foreach(string data in currentIP)
                {
                    tmp = "/c netsh interface ipv4 add address \"Ethernet\" " + data.Split('&')[0] + " " + data.Split('(')[1].Split(' ')[1].Split(')')[0];
                    SetProcessCMD(tmp);
                }
            }
            catch (Win32Exception) { }
            timer1.Enabled = true;
            //Thread.Sleep(4000);
            //GetConfigEthernet();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GetConfigEthernet();
            if (label5.Text == "Нет")
                SaveToFile();
            timer1.Enabled = false;
        }
    }
}
