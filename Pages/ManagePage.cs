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
    public partial class ManagePage : UserControl
    {
        MySQL_Client client;
        public ManagePage()
        {
            InitializeComponent();
            client = new MySQL_Client();
        }

        private void ManagePage_Load(object sender, EventArgs e)
        {
            DataSet ds = client.GetStudents();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(dr["StudentID"].ToString(), dr["Name"].ToString(), dr["Telephone"].ToString(), dr["Rfid"].ToString());
            }
        }

        private void searchBTN_Click(object sender, EventArgs e)
        {
            String keyword=searchTxt.Text;
            if(keyword.Length>1)
            {
                dataGridView1.Rows.Clear();
                DataSet ds = client.SearchStudent(keyword.ToString());
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    dataGridView1.Rows.Add(dr["StudentID"].ToString(), dr["Name"].ToString(), dr["Telephone"].ToString(), dr["Rfid"].ToString());
                }
            }
        }

        private void viewallBTN_Click(object sender, EventArgs e)
        {
            getAll();
        }

        private void deleteBTN_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedRowIndex = dataGridView1.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dataGridView1.Rows[selectedRowIndex];
                var cellValue = selectedRow.Cells[3].Value;
                Boolean res =client.DeleteStudent(cellValue.ToString());
                if (res) 
                {
                    getAll();
                    MessageBox.Show("Student Deleted", "Action Completed");
                }
                else
                {
                    MessageBox.Show("Student Delete Failed", "Action Faild");
                }
            }
        }

        private void getAll()
        {
            dataGridView1.Rows.Clear();
            DataSet ds = client.GetStudents();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                dataGridView1.Rows.Add(dr["StudentID"].ToString(), dr["Name"].ToString(), dr["Telephone"].ToString(), dr["Rfid"].ToString());
            }
        }
    }
}
