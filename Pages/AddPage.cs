using Attendance_System.Models;
using Attendance_System.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attendance_System.Pages
{
    public partial class AddPage : UserControl
    {
        Student student = new Student();
        MySQL_Client client;
        public AddPage()
        {
            InitializeComponent();
            //textStudentRFID.Enabled = false;
            client = new MySQL_Client();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            student.StudentId = int.Parse(textStudentId.Text);
            student.Name = textStudentName.Text;
            student.Telephone = textStudentTelephone.Text;

            if (student.StudentId != 0 && student.Name != null && student.Telephone != null && student.Rfid != null) 
            { 
                    Boolean res = client.CreateStudent(student);
                    if (res)
                    {
                    textStudentId.Text = "";
                    textStudentName.Text = "";
                    textStudentTelephone.Text = "";
                    textStudentRFID.Text = "";
                    MessageBox.Show("Success", "Success");

                    }
            }
            else
            {
                MessageBox.Show("Failed,if", student.Rfid);

            }
        }

        public void UpdateRFID(String rfid)
        {
            if (client.GetStudent(student.Rfid) != null)
            {
                MessageBox.Show("This RFID Already in Server", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textStudentRFID.Text = "";

            }
            else
            {
                this.student.Rfid = rfid;
                this.textStudentRFID.Text = rfid;
            }

            
            
            
            
        }
    }
}
