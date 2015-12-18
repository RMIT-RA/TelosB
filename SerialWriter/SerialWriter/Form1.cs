﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Runtime.InteropServices;
using System.Globalization;


namespace SerialWriter
{
    public partial class Form1 : Form
    {

        SerialPort sp;
        string fileName = "D:\\NALIKA\\EMPLOYEE\\Research Assistant - RMIT\\TelosB\\SerialWriter\\SerialWriter\\SerialData.txt";
        //string fileName = "C:\\Users\\SerialData.txt";

        System.IO.StreamWriter file;

        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();
        }

        void getAvailablePorts()
        {
            string[] ports = SerialPort.GetPortNames();
            comboBox1.Items.AddRange(ports);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.Text == "" || comboBox2.Text == "")
                {
                    statusLabel.ForeColor = Color.Red;
                    errorLabel.Text = "Please select the port and baudrate";
                }
                else
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = Convert.ToInt32(comboBox2.Text);
                    readData.Enabled = true;
                    initPort.Enabled = false;
                    errorLabel.Text = "";            
                }
            }
            catch(UnauthorizedAccessException)
            {
                errorLabel.Text = "Unauthorised Access !";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            sErial(serialPort1.PortName);

        }

        
        void sErial(string portName)
        {
            sp = new SerialPort(portName, serialPort1.BaudRate, Parity.None, 8, StopBits.One);
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            sp.Open();

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Port Status: Opened - Reading data and writing into file";
            closePort.Enabled = true;
            readData.Enabled = false;
            startInterrupt.Enabled = true;
            endInterrupt.Enabled = false;

            file = new System.IO.StreamWriter(fileName, true);
            DateTime localDate = DateTime.Now;
            file.WriteLine("File Started on: " + localDate.ToString());
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
           

            SerialPort sp = (SerialPort) sender;
            string w = sp.ReadLine();
            if (w != string.Empty)
            {
                statusLabel.ForeColor = Color.Blue;
               // label1.Text = "Port Status: Reading data and writing into file";
                Invoke(new Action(() => richTextBox1.AppendText(w)));
                file.WriteLine(w);



            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

                sp.Close();
                statusLabel.ForeColor = Color.Red;
                statusLabel.Text = "Port Status: Closed";
                file.Close();
                initPort.Enabled = true;
                readData.Enabled = false;
                closePort.Enabled = false;
                startInterrupt.Enabled = false;
                endInterrupt.Enabled = false;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            file.Write("Start Interrupt on ");
            DateTime localDate = DateTime.Now;
            file.WriteLine(localDate.ToString());

            endInterrupt.Enabled = true;
            startInterrupt.Enabled = false;
        }

        private void endInterrupt_Click(object sender, EventArgs e)
        {
            file.Write("End Interrupt on ");
            DateTime localDate = DateTime.Now;
            file.WriteLine(localDate.ToString());

            endInterrupt.Enabled = false;
            startInterrupt.Enabled = true;
        }

        
    }

}

