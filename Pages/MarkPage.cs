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
    public partial class MarkPage : UserControl
    {
        MySQL_Client client;
        public MarkPage()
        {
            InitializeComponent();
            client = new MySQL_Client();
            DateTime currentDate = DateTime.Now;

            int year = currentDate.Year;
            int month = currentDate.Month;
            int day = currentDate.Day;
            dateLabel.Text = day.ToString() +"/"+ month.ToString() +"/"+ year.ToString();

        }

        public void FillDetails(Student student)
        {
            

            lblID.Text = student.StudentId.ToString();
            lblName.Text = student.Name.ToString();
            getAttendance(student.Rfid);
            
        }

        public void resetData()
        {
            lblID.Text = "-";
            lblName.Text = "-";
            
        }

        public void getAttendance(String rfid)
        {
            Attendance attendance= client.GetAttendance(rfid);
            if (attendance is null || string.IsNullOrEmpty(attendance.RFID))

            {
                INlbl.Text = "Not Marked";
                OUTlbl.Text = "Not Marked";

                DateTime currentDate = DateTime.Now;

                int year = currentDate.Year;
                int month = currentDate.Month;
                int day = currentDate.Day;
                String time = currentDate.ToString("HH:mm:ss");

                Attendance new_attendance = new Attendance();
                new_attendance.RFID = rfid;
                new_attendance.Year = year.ToString();
                new_attendance.Month = month.ToString();
                new_attendance.Day = day.ToString();
                new_attendance.IN_TIME = time;
                //new_attendance.OUT_TIME = "";

                Boolean res = client.SetAttendance(new_attendance);
                if (res)
                {
                    INlbl.Text = time;
                    OUTlbl.Text = "Not Marked";
                    //getAttendance(rfid);
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {

                if (attendance.OUT_TIME is null || attendance.OUT_TIME =="")
                {
                    INlbl.Text = attendance.IN_TIME;
                    OUTlbl.Text = "Not Marked";
                    DateTime currentDate = DateTime.Now;
                    String time = currentDate.ToString("HH:mm:ss");


                    int result = DateTime.Compare(currentDate, new DateTime(int.Parse(attendance.Year), int.Parse(attendance.Month), int.Parse(attendance.Day), 12, 0, 0));

                    if (result > 0)
                    {
                        client.UpdateAttendance(time, rfid);
                        INlbl.Text = attendance.IN_TIME;
                        OUTlbl.Text = time;
                    }
                    else
                    {
                        MessageBox.Show("Wait untill 12.00 pm", "Already marked");
                    }
                }
                else
                {
                    INlbl.Text = attendance.IN_TIME;
                    OUTlbl.Text = attendance.OUT_TIME;

                }
            }
        }
    }
}
