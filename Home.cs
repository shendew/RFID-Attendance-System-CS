using System;
using System.IO;
using System.IO.Ports;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleHttp;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Collections.Generic;
using System.Linq;
using Attendance_System.Repository;
using System.Drawing;
using MaterialSkin.Controls;
using Attendance_System.Pages;
using Attendance_System.Models;
using System.Security.Cryptography;


namespace Attendance_System
{
    public partial class Home : Form
    {
        String[] ports;
        SerialPort Serial ;
        bool isConnected = false;

        private Thread serverThread;
        private TcpListener tcpListener;


        private List<int> bandList=new List<int> {300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 74880, 115200, 128000, 250000, 500000, 1000000, 2000000};

        string logText = "";
        HomePage hm;

        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            //this.TopMost = true;
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            baudList.DataSource = bandList;
            hm = new HomePage();
            addUserControl(hm);
            RFIDlabel.Size = new System.Drawing.Size(120, 25);
            getAvailableCOM_PORTS();

            foreach (string port in ports)
            {
                comboBox2.Items.Add(port);
                Console.WriteLine(port);

                if (ports[0] != null)
                {
                    comboBox2.SelectedItem = ports[0];
                }
            }



        }
        private void getAvailableCOM_PORTS()
        {
            ports = SerialPort.GetPortNames();
        }



        private void connectPortBtn_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                disconnectArduino();
            }
            else
            {
                connectToArduino();
            }
 
        }

        private void connectToArduino()
        {
            try
            {
                isConnected = true;
                string selectedPort = comboBox2.GetItemText(comboBox2.SelectedItem);
                string selectedBaud = baudList.GetItemText(baudList.SelectedItem);
                Serial = new SerialPort(selectedPort, int.Parse(selectedBaud), Parity.None, 8, StopBits.One);
                Serial.Open();
                Serial.DataReceived += new SerialDataReceivedEventHandler(port_OnReceiveDatazz);
                connectPortBtn.Text = "Stop";
                logBox.AppendText("Connected");
                logBox.AppendText(Environment.NewLine);

                comboBox2.Enabled = false;
                baudList.Enabled = false;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                logBox.AppendText("Connect failed :");
                logBox.AppendText(ex.Message);
                logBox.AppendText(Environment.NewLine);
            }

        }



        private void port_OnReceiveDatazz(object sender,
                                   SerialDataReceivedEventArgs e)
        {
            string indata = Serial.ReadExisting();
            

            this.Invoke(new MethodInvoker(delegate ()
            {
                Console.Write(indata);
                logBox.AppendText(indata);
                logText += indata;
                if (logText.Length >= 10)
                {
                    string rid = logText.Substring(logText.Length - 10);
                    RFIDlabel.Text = rid;
                    var client = new MySQL_Client();
                    var student = client.GetStudent(RFIDlabel.Text);
                    if (student != null) 
                    {
                        //studentidTextbox.Text = $"{student.StudentId}";
                        //studentNameTextbox.Text = student.Name;
                        //studentTeleTextBox.Text = student.Telephone;
                        hm.FillDetails(student);
                    }
                    else
                    {
                        hm.resetData();
                        //MessageBox.Show("This card is not registered yet.", "No Student found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }


                }
                


            }));

            Console.WriteLine();
        }

        private void disconnectArduino()
        {
            isConnected = false;
            string selectedPort = comboBox2.GetItemText(comboBox2.SelectedItem);
            Serial.Close();
            comboBox2.Enabled = true;
            baudList.Enabled = true;
            connectPortBtn.Text = "Read";
            hm.resetData();
            RFIDlabel.Text = "-";

        }

        private void onLoad(object sender, EventArgs e)
        {
            //int w=Screen.PrimaryScreen.Bounds.Width;
            //int h = Screen.PrimaryScreen.Bounds.Height;
            //this.Size = new Size(w, h);

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelController.Controls.Clear();
            panelController.Controls.Add(userControl);
            userControl.BringToFront();
        }
        private void Homebtn_Click(object sender, EventArgs e)
        {
            
            HomePage hm=new HomePage();
            addUserControl(hm);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AddPage ap=new AddPage();
            addUserControl(ap);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            UpdateStudent us=new UpdateStudent();
            addUserControl(us);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            DeletePage dp=new DeletePage();
            addUserControl(dp);
        }
    }

}
