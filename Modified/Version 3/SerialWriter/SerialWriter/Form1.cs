/**
 * AUTHOR: NALIKA DONA
 * CREATED ON: 24/NOV/2015
 * 
 * */

using System;
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
        //string fileName = "D:\\NALIKA\\EMPLOYEE\\Research Assistant - RMIT\\TelosB\\Modfified\\SerialWriter\\SerialWriter\\SerialData.txt";
        string fileName = "C:\\Users\\SerialData.txt";

      //  public class MultiDimDictList : Dictionary<string, List<int>> { }
     //   MultiDimDictList rssiValues = new MultiDimDictList();

        List<List<int>> rssiValuesRecv = new List<List<int>>();
        List<List<int>> rssiValuesSend = new List<List<int>>();

        //List<int> rssiValues = new List<int>();
        //int[] rssiValues = new int[5];
        int fromNode = 4;
        int toNode = 0;
        string selectedNode = "";

        System.IO.StreamWriter file;

        public Form1()
        {
            InitializeComponent();
            getAvailablePorts();

            for (int i = 0; i < 6; i++)
            {
                rssiValuesRecv.Add(new List<int>());
                rssiValuesSend.Add(new List<int>());
            }
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
                    statusLabel.ForeColor = Color.Green;
                    statusLabel.Text = "Port Initialized";
                }
            }
            catch(UnauthorizedAccessException)
            {
                errorLabel.Text = "Unauthorised Access !";
            } 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (selectedNode == "")
            {
                statusLabel.ForeColor = Color.Red;
                errorLabel.Text = "Please select a Node";
            }
            else
            {
                errorLabel.Text = "";
                sErial(serialPort1.PortName);
            }

        }

        
        void sErial(string portName)
        {
            sp = new SerialPort(portName, serialPort1.BaudRate, Parity.None, 8, StopBits.One);
            sp.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            sp.Open();

            statusLabel.ForeColor = Color.Green;
            statusLabel.Text = "Port Status: Opened - Reading data and writing into \"" + fileName + "\"";
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
                string[] values = w.Split(new[] {"\t", "\t"}, StringSplitOptions.None);
                string[] nodes = values[0].Split(new[] {"[", ",", "]"}, StringSplitOptions.None);
                

                // Plotting chartReceived (bottom chart)
                try
                {
                    if (nodes[2] == selectedNode)
                    {
                        rssiValuesRecv[Convert.ToInt16(nodes[1])].Add(Convert.ToInt16(values[1]));
//                        Invoke(new Action(() => richTextBox1.AppendText(Convert.ToString(rssiValues[Convert.ToInt16(nodes[1])][0]))));
                        if (rssiValuesRecv[Convert.ToInt16(nodes[1])].Count > 60)
                        {
                            rssiValuesRecv[Convert.ToInt16(nodes[1])].RemoveAt(0);
                        }

                        Invoke(new Action(() => chartReceive.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValuesRecv[Convert.ToInt16(nodes[1])])));
                    }
         
                }
                catch (InvalidOperationException)
                {
                    errorLabel.Text = "Error!";
                }

                //Plotting chartSent (upper chart)
                try
                {
                    if (nodes[1] == selectedNode)
                    {
                        rssiValuesSend[Convert.ToInt16(nodes[2])].Add(Convert.ToInt16(values[1]));
                        //                        Invoke(new Action(() => richTextBox1.AppendText(Convert.ToString(rssiValues[Convert.ToInt16(nodes[1])][0]))));
                        if (rssiValuesSend[Convert.ToInt16(nodes[2])].Count > 60)
                        {
                            rssiValuesSend[Convert.ToInt16(nodes[2])].RemoveAt(0);
                        }

                        Invoke(new Action(() => chartSend.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValuesSend[Convert.ToInt16(nodes[2])])));
                    }

                }
                catch (InvalidOperationException)
                {
                    errorLabel.Text = "Error!";
                }

     /*           for (int i = 0; i < 6; i++)
                {
                    if (i != (Convert.ToInt16(nodes[2])))
                    {
                        Invoke(new Action(() => chart1.Series[i].Points.DataBindY(rssiValues[i])));
                    }
                }
    */
                    statusLabel.ForeColor = Color.Blue;
               // label1.Text = "Port Status: Reading data and writing into file";

                Invoke(new Action(() => richTextBox1.AppendText(w)));
           //     Invoke(new Action(() => richTextBox1.AppendText(values[0])));
                //Invoke(new Action(() => chart1.Series["RSSI Value"].Points.AddY(values[1])));

//                Invoke(new Action(() => chart1.Series["2"].Points.DataBindY(rssiValues[5])));


            /*    foreach (string s in nodes)
                {
                    file.WriteLine(s);
                }*/
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

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            //this.chart1.Series["RSSI Value"].Points.AddY(20);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void selectNode_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedNode = selectNode.Text;
            chartReceivLabel.Text = "Plot of RSSI measured at (Received by) node " + selectedNode + " when the packets are sent by all other nodes. Eg: (All - " + selectedNode + " )";
            chartSendLabel.Text = "Plot of RSSI measured at (Received by) all other nodes when the packets are sent by node " + selectedNode + ". Eg: ( " + selectedNode + " - All )";

            for (int i = 0; i < 6; i++)
            {
                rssiValuesRecv[i].Clear();
                rssiValuesSend[i].Clear();
                Invoke(new Action(() => chartSend.Series[Convert.ToInt16(i)].Points.DataBindY(rssiValuesRecv[Convert.ToInt16(i)])));
                Invoke(new Action(() => chartReceive.Series[Convert.ToInt16(i)].Points.DataBindY(rssiValuesRecv[Convert.ToInt16(i)])));
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        
    }

}

