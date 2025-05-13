namespace Attendance_System.Pages
{
    partial class MarkPage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OUTlbl = new System.Windows.Forms.Label();
            this.INlbl = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(421, 207);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(17, 24);
            this.lblName.TabIndex = 16;
            this.lblName.Text = "-";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(421, 132);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(17, 24);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "-";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(343, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 24);
            this.label7.TabIndex = 14;
            this.label7.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(343, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(16, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = ":";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(108, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Student Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Student ID";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.OUTlbl);
            this.panel1.Controls.Add(this.INlbl);
            this.panel1.Location = new System.Drawing.Point(304, 449);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(746, 164);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(740, 44);
            this.panel2.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(525, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 31);
            this.label4.TabIndex = 13;
            this.label4.Text = "OUT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(168, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 31);
            this.label3.TabIndex = 12;
            this.label3.Text = "IN";
            // 
            // OUTlbl
            // 
            this.OUTlbl.AutoSize = true;
            this.OUTlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OUTlbl.Location = new System.Drawing.Point(488, 98);
            this.OUTlbl.Name = "OUTlbl";
            this.OUTlbl.Size = new System.Drawing.Size(154, 31);
            this.OUTlbl.TabIndex = 15;
            this.OUTlbl.Text = "Not Marked";
            this.OUTlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // INlbl
            // 
            this.INlbl.AutoSize = true;
            this.INlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.INlbl.Location = new System.Drawing.Point(115, 98);
            this.INlbl.Name = "INlbl";
            this.INlbl.Size = new System.Drawing.Size(154, 31);
            this.INlbl.TabIndex = 14;
            this.INlbl.Text = "Not Marked";
            this.INlbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.dateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(383, 362);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(216, 42);
            this.dateLabel.TabIndex = 18;
            this.dateLabel.Text = "12/02/2025";
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timeLabel.AutoSize = true;
            this.timeLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.Location = new System.Drawing.Point(745, 362);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(236, 42);
            this.timeLabel.TabIndex = 19;
            this.timeLabel.Text = "00:00:00 pm";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Location = new System.Drawing.Point(304, 333);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(373, 100);
            this.panel3.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Location = new System.Drawing.Point(675, 333);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(373, 100);
            this.panel4.TabIndex = 21;
            // 
            // MarkPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Name = "MarkPage";
            this.Size = new System.Drawing.Size(1338, 702);
            this.Load += new System.EventHandler(this.MarkPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label OUTlbl;
        private System.Windows.Forms.Label INlbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
    }
}
