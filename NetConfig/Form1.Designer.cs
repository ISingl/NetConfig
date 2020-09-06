namespace NetConfig
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnDynamic = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDHCP = new System.Windows.Forms.Label();
            this.btnDeleteIp = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddIp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMask = new System.Windows.Forms.TextBox();
            this.txtIp = new System.Windows.Forms.TextBox();
            this.btnStatic = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDynamic
            // 
            this.btnDynamic.Location = new System.Drawing.Point(254, 201);
            this.btnDynamic.Name = "btnDynamic";
            this.btnDynamic.Size = new System.Drawing.Size(132, 23);
            this.btnDynamic.TabIndex = 0;
            this.btnDynamic.Text = "Включить DHCP IP";
            this.btnDynamic.UseVisualStyleBackColor = true;
            this.btnDynamic.Click += new System.EventHandler(this.Button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDHCP);
            this.groupBox1.Controls.Add(this.btnDeleteIp);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка интерфейса Ethernet";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "unknown";
            // 
            // labelDHCP
            // 
            this.labelDHCP.AutoSize = true;
            this.labelDHCP.Location = new System.Drawing.Point(147, 21);
            this.labelDHCP.Name = "labelDHCP";
            this.labelDHCP.Size = new System.Drawing.Size(51, 13);
            this.labelDHCP.TabIndex = 4;
            this.labelDHCP.Text = "unknown";
            // 
            // btnDeleteIp
            // 
            this.btnDeleteIp.Location = new System.Drawing.Point(258, 83);
            this.btnDeleteIp.Name = "btnDeleteIp";
            this.btnDeleteIp.Size = new System.Drawing.Size(130, 23);
            this.btnDeleteIp.TabIndex = 3;
            this.btnDeleteIp.Text = "Удалить IP-адрес";
            this.btnDeleteIp.UseVisualStyleBackColor = true;
            this.btnDeleteIp.Click += new System.EventHandler(this.BtnDeleteIp_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 37);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(189, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Префикс подсети:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP - адрес:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "DHCP:";
            // 
            // btnAddIp
            // 
            this.btnAddIp.Location = new System.Drawing.Point(42, 77);
            this.btnAddIp.Name = "btnAddIp";
            this.btnAddIp.Size = new System.Drawing.Size(116, 23);
            this.btnAddIp.TabIndex = 4;
            this.btnAddIp.Text = "Добавить IP-адрес";
            this.btnAddIp.UseVisualStyleBackColor = true;
            this.btnAddIp.Click += new System.EventHandler(this.BtnAddIp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.btnAddIp);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtMask);
            this.groupBox2.Controls.Add(this.txtIp);
            this.groupBox2.Location = new System.Drawing.Point(12, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(210, 109);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Дополнительно";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Маска:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "IP-адрес:";
            // 
            // txtMask
            // 
            this.txtMask.Location = new System.Drawing.Point(78, 48);
            this.txtMask.Name = "txtMask";
            this.txtMask.Size = new System.Drawing.Size(116, 20);
            this.txtMask.TabIndex = 1;
            // 
            // txtIp
            // 
            this.txtIp.Location = new System.Drawing.Point(78, 22);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(116, 20);
            this.txtIp.TabIndex = 0;
            // 
            // btnStatic
            // 
            this.btnStatic.Location = new System.Drawing.Point(254, 165);
            this.btnStatic.Name = "btnStatic";
            this.btnStatic.Size = new System.Drawing.Size(132, 23);
            this.btnStatic.TabIndex = 7;
            this.btnStatic.Text = "Включить STATIC IP";
            this.btnStatic.UseVisualStyleBackColor = true;
            this.btnStatic.Click += new System.EventHandler(this.BtnStatic_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 259);
            this.Controls.Add(this.btnStatic);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDynamic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NetConfig ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDynamic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDHCP;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnDeleteIp;
        private System.Windows.Forms.Button btnAddIp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMask;
        private System.Windows.Forms.TextBox txtIp;
        private System.Windows.Forms.Button btnStatic;
        private System.Windows.Forms.Timer timer1;
    }
}

