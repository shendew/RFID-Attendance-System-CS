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
        public Home()
        {
            InitializeComponent();
            baudList.DataSource = bandList;
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
                connectPortBtn.Text = "Disconnect";
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
                RFID.Text = logText.Substring(logText.Length-6);
                
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
            connectPortBtn.Text = "Connect";
        }

    }

}
