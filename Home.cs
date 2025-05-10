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


        //private List<int> bandList=new List<int> {300, 1200, 2400, 4800, 9600, 14400, 19200, 28800, 38400, 57600, 74880, 115200, 128000, 250000, 500000, 1000000, 2000000};
        private List<int> bandList = new List<int> { 9600};

        string logText = "";

        HomePage homePage;
        AddPage addPage;
        MarkPage markPage;
        ManagePage managePage;

        int tabStat = 0;

        public Home()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            baudList.DataSource = bandList;

            homePage = new HomePage();
            addPage= new AddPage();
            markPage=new MarkPage();
            managePage= new ManagePage();

            addUserControl(homePage);
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
                        if (tabStat == 0)
                        {
                            markPage.FillDetails(student);
                            
                            
                        } 
                        else if (tabStat == 1)
                        {
                            homePage.FillDetails(student);
                            
                        }
                        else if (tabStat == 3)
                        {
                            
                        }
                    }
                    else
                    {
                        if (tabStat == 2)
                        {
                            addPage.UpdateRFID(RFIDlabel.Text);
                            
                        }
                        else
                        {
                            homePage.resetData();
                        }
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
            homePage.resetData();
            RFIDlabel.Text = "No RFID Found";
        }

        private void onLoad(object sender, EventArgs e){}

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelController.Controls.Clear();
            panelController.Controls.Add(userControl);
            userControl.BringToFront();
        }



        private void Attendancebtn_Click(object sender, EventArgs e)
        {
            addUserControl(markPage);
            tabStat = 0;
        }

        private void Homebtn_Click(object sender, EventArgs e)
        {
            addUserControl(homePage);
            tabStat = 1;
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            addUserControl(addPage);
            tabStat = 2;
        }

        private void Managebtn_Click(object sender, EventArgs e)
        {
            addUserControl(managePage);
            tabStat = 3;
        }
    }

}
