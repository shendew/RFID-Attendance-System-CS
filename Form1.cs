using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Attendance_System
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            // Create a material theme manager and add the form to manage (this)
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            // Configure color schema
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Username= userNameTextBox.Text;
            String Password=userPasswordTextBox.Text;

            if (Username.Length == 0) {
                MessageBox.Show("Username is Required");
            }
            if (Password.Length == 0)
            {
                MessageBox.Show("Password is Required");
            }

            if(Username=="test" && Password == "test")
            {
                Home home = new Home();
                home.Show();
                this.Hide();    
            }
        }
    }
}
