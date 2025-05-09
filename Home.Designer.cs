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
            this.RFIDlabel = new System.Windows.Forms.Label();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.baudList = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panelController = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Attendancebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Managebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ViewStudentbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(863, 152);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(198, 21);
            this.comboBox2.TabIndex = 0;
            // 
            // connectPortBtn
            // 
            this.connectPortBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.connectPortBtn.AutoSize = true;
            this.connectPortBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.connectPortBtn.Depth = 0;
            this.connectPortBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connectPortBtn.Icon = null;
            this.connectPortBtn.Location = new System.Drawing.Point(1005, 241);
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
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(862, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Avaible Ports";
            // 
            // RFIDlabel
            // 
            this.RFIDlabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RFIDlabel.AutoSize = true;
            this.RFIDlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RFIDlabel.Location = new System.Drawing.Point(31, 22);
            this.RFIDlabel.Name = "RFIDlabel";
            this.RFIDlabel.Size = new System.Drawing.Size(147, 25);
            this.RFIDlabel.TabIndex = 3;
            this.RFIDlabel.Text = "No RFID Found";
            this.RFIDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logBox
            // 
            this.logBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logBox.Location = new System.Drawing.Point(863, 458);
            this.logBox.Name = "logBox";
            this.logBox.Size = new System.Drawing.Size(205, 219);
            this.logBox.TabIndex = 4;
            this.logBox.Text = "";
            // 
            // baudList
            // 
            this.baudList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.baudList.FormattingEnabled = true;
            this.baudList.Location = new System.Drawing.Point(863, 196);
            this.baudList.Name = "baudList";
            this.baudList.Size = new System.Drawing.Size(198, 21);
            this.baudList.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Baud";
            // 
            // panelController
            // 
            this.panelController.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelController.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelController.Location = new System.Drawing.Point(273, 72);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(584, 617);
            this.panelController.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Outlook", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(352, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(340, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "RFID Attendance System";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(937, 349);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "RFID Code";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.RFIDlabel);
            this.panel2.Location = new System.Drawing.Point(863, 365);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(204, 69);
            this.panel2.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1080, 66);
            this.panel4.TabIndex = 12;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Controls.Add(this.Attendancebtn);
            this.panel3.Controls.Add(this.Managebtn);
            this.panel3.Controls.Add(this.Addbtn);
            this.panel3.Controls.Add(this.ViewStudentbtn);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 623);
            this.panel3.TabIndex = 13;
            // 
            // Attendancebtn
            // 
            this.Attendancebtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Attendancebtn.CustomBorderColor = System.Drawing.Color.White;
            this.Attendancebtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Attendancebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Attendancebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Attendancebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Attendancebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Attendancebtn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.Attendancebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendancebtn.ForeColor = System.Drawing.Color.White;
            this.Attendancebtn.Location = new System.Drawing.Point(3, 31);
            this.Attendancebtn.Name = "Attendancebtn";
            this.Attendancebtn.Size = new System.Drawing.Size(261, 45);
            this.Attendancebtn.TabIndex = 4;
            this.Attendancebtn.Text = "Mark Attendance";
            this.Attendancebtn.Click += new System.EventHandler(this.Attendancebtn_Click);
            // 
            // Managebtn
            // 
            this.Managebtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Managebtn.CustomBorderColor = System.Drawing.Color.White;
            this.Managebtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Managebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Managebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Managebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Managebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Managebtn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.Managebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Managebtn.ForeColor = System.Drawing.Color.White;
            this.Managebtn.Location = new System.Drawing.Point(3, 298);
            this.Managebtn.Name = "Managebtn";
            this.Managebtn.Size = new System.Drawing.Size(261, 45);
            this.Managebtn.TabIndex = 2;
            this.Managebtn.Text = "Manage Students";
            this.Managebtn.Click += new System.EventHandler(this.Managebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BackColor = System.Drawing.SystemColors.Highlight;
            this.Addbtn.CustomBorderColor = System.Drawing.Color.White;
            this.Addbtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbtn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(3, 210);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(261, 45);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "Add Student";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // ViewStudentbtn
            // 
            this.ViewStudentbtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ViewStudentbtn.CustomBorderColor = System.Drawing.Color.White;
            this.ViewStudentbtn.CustomBorderThickness = new System.Windows.Forms.Padding(1);
            this.ViewStudentbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ViewStudentbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ViewStudentbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ViewStudentbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ViewStudentbtn.FillColor = System.Drawing.SystemColors.HotTrack;
            this.ViewStudentbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewStudentbtn.ForeColor = System.Drawing.Color.White;
            this.ViewStudentbtn.Location = new System.Drawing.Point(3, 118);
            this.ViewStudentbtn.Name = "ViewStudentbtn";
            this.ViewStudentbtn.Size = new System.Drawing.Size(261, 45);
            this.ViewStudentbtn.TabIndex = 0;
            this.ViewStudentbtn.Text = "View Student";
            this.ViewStudentbtn.Click += new System.EventHandler(this.Homebtn_Click);
            // 
            // Home
            // 
            this.ClientSize = new System.Drawing.Size(1080, 689);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.baudList);
            this.Controls.Add(this.logBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.connectPortBtn);
            this.Controls.Add(this.comboBox2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.onLoad);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label RFIDlabel;
        private System.Windows.Forms.RichTextBox logBox;
        private System.Windows.Forms.ComboBox baudList;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panelController;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button ViewStudentbtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2Button Managebtn;
        private Guna.UI2.WinForms.Guna2Button Attendancebtn;
    }
}