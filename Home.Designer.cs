namespace Attendance_System
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.connectPortBtn = new MaterialSkin.Controls.MaterialFlatButton();
            this.label2 = new System.Windows.Forms.Label();
            this.RFID = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.baudList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(977, 44);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(205, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // connectPortBtn
            // 
            this.connectPortBtn.AutoSize = true;
            this.connectPortBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectPortBtn.Depth = 0;
            this.connectPortBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectPortBtn.Icon = null;
            this.connectPortBtn.Location = new System.Drawing.Point(1126, 133);
            this.connectPortBtn.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.connectPortBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.connectPortBtn.Name = "connectPortBtn";
            this.connectPortBtn.Primary = false;
            this.connectPortBtn.Size = new System.Drawing.Size(55, 36);
            this.connectPortBtn.TabIndex = 1;
            this.connectPortBtn.Text = "Read";
            this.connectPortBtn.UseVisualStyleBackColor = true;
            this.connectPortBtn.Click += new System.EventHandler(this.connectPortBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(983, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaible Ports";
            // 
            // RFID
            // 
            this.RFID.AutoSize = true;
            this.RFID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFID.Location = new System.Drawing.Point(90, 18);
            this.RFID.Name = "RFID";
            this.RFID.Size = new System.Drawing.Size(19, 25);
            this.RFID.TabIndex = 3;
            this.RFID.Text = "-";
            // 
            // logBox
            // 
            this.logBox.Location = new System.Drawing.Point(977, 300);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(205, 285);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // baudList
            // 
            this.baudList.FormattingEnabled = true;
            this.baudList.Location = new System.Drawing.Point(977, 88);
            this.baudList.Name = "baudList";
            this.baudList.Size = new System.Drawing.Size(205, 21);
            this.baudList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(983, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Baud";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 497);
            this.panel1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Outlook", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(451, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "RFID Attendance System";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1051, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RFID Code";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.RFID);
            this.panel2.Location = new System.Drawing.Point(977, 215);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 63);
            this.panel2.TabIndex = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 91);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(249, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telephone";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 177);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(249, 20);
            this.textBox2.TabIndex = 11;
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(1194, 597);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudList);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectPortBtn);
            this.Controls.Add(this.comboBox2);
            this.Name = "Home";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton connectBtn;
        private System.Windows.Forms.ComboBox comboBox2;
        private MaterialSkin.Controls.MaterialFlatButton connectPortBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label RFID;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox baudList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
    }
}