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
    public partial class mainForm : Form
    {

        SerialPort sp;
        //string fileName = "D:\\NALIKA\\EMPLOYEE\\Research Assistant - RMIT\\TelosB\\Modfified\\SerialWriter\\SerialWriter\\SerialData.txt";
        //string fileName = "C:\\Users\\SerialData.txt";
        string fileName = "D:\\SerialData.txt";

      //  public class MultiDimDictList : Dictionary<string, List<int>> { }
     //   MultiDimDictList rssiValues = new MultiDimDictList();

        List<List<List<int>>> rssiValues = new List<List<List<int>>>();
  //      List<List<List<int>>> rssiValuesSend = new List<List<List<int>>>();

        //List<int> rssiValues = new List<int>();
        //int[] rssiValues = new int[5];
        int fromNode, toNode;
        string selectedNode = "";

        System.IO.StreamWriter file;

        public mainForm()
        {
            InitializeComponent();
            getAvailablePorts();

            for (int from = 0; from < 6; from++)
            {
                rssiValues.Add(new List<List<int>>());
                for (int to = 0; to < 6; to++ )
                {
                    rssiValues[from].Add(new List<int>());                  
                } 
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
                
                //Filling 3D array
                rssiValues[Convert.ToInt16(nodes[1])][Convert.ToInt16(nodes[2])].Add(Convert.ToInt16(values[1]));
                if (rssiValues[Convert.ToInt16(nodes[1])][Convert.ToInt16(nodes[2])].Count > 60)
                {
                    rssiValues[Convert.ToInt16(nodes[1])][Convert.ToInt16(nodes[2])].RemoveAt(0);
                }

                // Plotting chartReceived (bottom chart)
                try
                {
                    if (nodes[2] == selectedNode)
                    {
                        Invoke(new Action(() => chartReceive.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][Convert.ToInt16(nodes[2])])));
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
                        Invoke(new Action(() => chartSend.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][Convert.ToInt16(nodes[2])])));
                    }

                }
                catch (InvalidOperationException)
                {
                    errorLabel.Text = "Error!";
                }


                //Plotting chartsReceived (6 leftmost charts) in the panel
                if(Convert.ToInt16(nodes[2]) == 0)
                {
                    Invoke(new Action(() => Receiver_0.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][0])));
                }
                else if(Convert.ToInt16(nodes[2]) == 1)
                {
                    Invoke(new Action(() => Receiver_1.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][1])));
                }
                else if (Convert.ToInt16(nodes[2]) == 2)
                {
                    Invoke(new Action(() => Receiver_2.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][2])));
                }
                else if (Convert.ToInt16(nodes[2]) == 3)
                {
                    Invoke(new Action(() => Receiver_3.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][3])));
                }
                else if (Convert.ToInt16(nodes[2]) == 4)
                {
                    Invoke(new Action(() => Receiver_4.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][4])));
                }
                else if (Convert.ToInt16(nodes[2]) == 5)
                {
                    Invoke(new Action(() => Receiver_5.Series[Convert.ToInt16(nodes[1])].Points.DataBindY(rssiValues[Convert.ToInt16(nodes[1])][5])));
                }

                //Plotting chartsSent (6 rightmost charts) in the panel
                if (Convert.ToInt16(nodes[1]) == 0)
                {
                    Invoke(new Action(() => Sender_0.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[0][Convert.ToInt16(nodes[2])])));
                }
                else if (Convert.ToInt16(nodes[1]) == 1)
                {
                    Invoke(new Action(() => Sender_1.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[1][Convert.ToInt16(nodes[2])])));
                }
                else if (Convert.ToInt16(nodes[1]) == 2)
                {
                    Invoke(new Action(() => Sender_2.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[2][Convert.ToInt16(nodes[2])])));
                }
                else if (Convert.ToInt16(nodes[1]) == 3)
                {
                    Invoke(new Action(() => Sender_3.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[3][Convert.ToInt16(nodes[2])])));
                }
                else if (Convert.ToInt16(nodes[1]) == 4)
                {
                    Invoke(new Action(() => Sender_4.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[4][Convert.ToInt16(nodes[2])])));
                }
                else if (Convert.ToInt16(nodes[1]) == 5)
                {
                    Invoke(new Action(() => Sender_5.Series[Convert.ToInt16(nodes[2])].Points.DataBindY(rssiValues[5][Convert.ToInt16(nodes[2])])));
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
                for (int j = 0; j < 6; j++)
                {
                    rssiValues[i][j].Clear();
                    Invoke(new Action(() => chartReceive.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => chartSend.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_0.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_1.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_2.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_3.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_4.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Receiver_5.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_0.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_1.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_2.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_3.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_4.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));
                    Invoke(new Action(() => Sender_5.Series[Convert.ToInt16(j)].Points.DataBindY(rssiValues[i][j])));

                }
            }

            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            allGraphsPanel.Size = new System.Drawing.Size(1240, 920);
            allGraphsPanel.Show();
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            allGraphsPanel.Hide();
        }

        
    }

}

