using Attendance_System.Models;
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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        public void FillDetails(Student student)
        {
            lblID.Text=student.StudentId.ToString();
            lblName.Text=student.Name.ToString();
            lblTele.Text=student.Telephone;
            lblRFID.Text=student.Rfid;
        }

        public void resetData()
        {
            lblID.Text = "-";
            lblName.Text = "-";
            lblTele.Text = "-";
            lblRFID.Text = "-";
        }
    }
}
