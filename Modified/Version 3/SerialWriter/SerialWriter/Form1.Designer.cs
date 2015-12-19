namespace SerialWriter
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.initPort = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.readData = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.closePort = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.portsLabel = new System.Windows.Forms.Label();
            this.baudRateLabel = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.errorLabel = new System.Windows.Forms.Label();
            this.startInterrupt = new System.Windows.Forms.Button();
            this.endInterrupt = new System.Windows.Forms.Button();
            this.chartReceive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartReceivLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chartSend = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartSendLabel = new System.Windows.Forms.Label();
            this.selectNode = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartReceive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSend)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // initPort
            // 
            this.initPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initPort.Location = new System.Drawing.Point(884, 1);
            this.initPort.Name = "initPort";
            this.initPort.Size = new System.Drawing.Size(106, 32);
            this.initPort.TabIndex = 0;
            this.initPort.Text = "Init Port";
            this.initPort.UseVisualStyleBackColor = true;
            this.initPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 24);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(159, 646);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // readData
            // 
            this.readData.Enabled = false;
            this.readData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readData.Location = new System.Drawing.Point(997, 1);
            this.readData.Name = "readData";
            this.readData.Size = new System.Drawing.Size(122, 32);
            this.readData.TabIndex = 2;
            this.readData.Text = "Read Data";
            this.readData.UseVisualStyleBackColor = true;
            this.readData.Click += new System.EventHandler(this.button2_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.Location = new System.Drawing.Point(204, 55);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // closePort
            // 
            this.closePort.Enabled = false;
            this.closePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePort.Location = new System.Drawing.Point(1125, 1);
            this.closePort.Name = "closePort";
            this.closePort.Size = new System.Drawing.Size(110, 32);
            this.closePort.TabIndex = 4;
            this.closePort.Text = "Close Port";
            this.closePort.UseVisualStyleBackColor = true;
            this.closePort.Click += new System.EventHandler(this.button3_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 24);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // portsLabel
            // 
            this.portsLabel.AutoSize = true;
            this.portsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portsLabel.Location = new System.Drawing.Point(205, 4);
            this.portsLabel.Name = "portsLabel";
            this.portsLabel.Size = new System.Drawing.Size(102, 17);
            this.portsLabel.TabIndex = 6;
            this.portsLabel.Text = "Available Ports";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateLabel.Location = new System.Drawing.Point(398, 2);
            this.baudRateLabel.Name = "baudRateLabel";
            this.baudRateLabel.Size = new System.Drawing.Size(75, 17);
            this.baudRateLabel.TabIndex = 7;
            this.baudRateLabel.Text = "Baud Rate";
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(401, 22);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(204, 56);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 9;
            // 
            // startInterrupt
            // 
            this.startInterrupt.Enabled = false;
            this.startInterrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInterrupt.ForeColor = System.Drawing.Color.Red;
            this.startInterrupt.Location = new System.Drawing.Point(981, 39);
            this.startInterrupt.Name = "startInterrupt";
            this.startInterrupt.Size = new System.Drawing.Size(133, 37);
            this.startInterrupt.TabIndex = 10;
            this.startInterrupt.Text = "Start Interrupt";
            this.startInterrupt.UseVisualStyleBackColor = true;
            this.startInterrupt.Click += new System.EventHandler(this.button4_Click);
            // 
            // endInterrupt
            // 
            this.endInterrupt.Enabled = false;
            this.endInterrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endInterrupt.ForeColor = System.Drawing.Color.Blue;
            this.endInterrupt.Location = new System.Drawing.Point(1120, 39);
            this.endInterrupt.Name = "endInterrupt";
            this.endInterrupt.Size = new System.Drawing.Size(115, 37);
            this.endInterrupt.TabIndex = 11;
            this.endInterrupt.Text = "End Interrupt";
            this.endInterrupt.UseVisualStyleBackColor = true;
            this.endInterrupt.Click += new System.EventHandler(this.endInterrupt_Click);
            // 
            // chartReceive
            // 
            chartArea3.AxisX.IsLabelAutoFit = false;
            chartArea3.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisX.Title = "Packets received";
            chartArea3.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea3.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea3.AxisY.Maximum = 30D;
            chartArea3.AxisY.Minimum = -30D;
            chartArea3.AxisY.Title = "RSSI Value";
            chartArea3.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea3.CursorX.AutoScroll = false;
            chartArea3.InnerPlotPosition.Auto = false;
            chartArea3.InnerPlotPosition.Height = 88F;
            chartArea3.InnerPlotPosition.Width = 91.74339F;
            chartArea3.InnerPlotPosition.X = 8.256607F;
            chartArea3.Name = "ChartArea1";
            this.chartReceive.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartReceive.Legends.Add(legend3);
            this.chartReceive.Location = new System.Drawing.Point(200, 383);
            this.chartReceive.Name = "chartReceive";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Color = System.Drawing.Color.Blue;
            series13.Legend = "Legend1";
            series13.Name = "Node 0";
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series14.Legend = "Legend1";
            series14.Name = "Node 1";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series15.Legend = "Legend1";
            series15.Name = "Node 2";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Color = System.Drawing.Color.Red;
            series16.Legend = "Legend1";
            series16.Name = "Node 3";
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series17.Legend = "Legend1";
            series17.Name = "Node 4";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series18.Legend = "Legend1";
            series18.Name = "Node 5";
            this.chartReceive.Series.Add(series13);
            this.chartReceive.Series.Add(series14);
            this.chartReceive.Series.Add(series15);
            this.chartReceive.Series.Add(series16);
            this.chartReceive.Series.Add(series17);
            this.chartReceive.Series.Add(series18);
            this.chartReceive.Size = new System.Drawing.Size(1035, 287);
            this.chartReceive.TabIndex = 12;
            this.chartReceive.Text = "chart1";
            title3.Name = "Plot of RSSI Value";
            this.chartReceive.Titles.Add(title3);
            this.chartReceive.Click += new System.EventHandler(this.chart1_Click);
            // 
            // chartReceivLabel
            // 
            this.chartReceivLabel.AutoSize = true;
            this.chartReceivLabel.BackColor = System.Drawing.Color.White;
            this.chartReceivLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartReceivLabel.Location = new System.Drawing.Point(301, 390);
            this.chartReceivLabel.Name = "chartReceivLabel";
            this.chartReceivLabel.Size = new System.Drawing.Size(156, 15);
            this.chartReceivLabel.TabIndex = 13;
            this.chartReceivLabel.Text = "Plot of RSSI measured ";
            this.chartReceivLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chartReceivLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "[From,To]";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "RSSI";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(132, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Time";
            // 
            // chartSend
            // 
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.Title = "Packets sent ";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.Maximum = 30D;
            chartArea4.AxisY.Minimum = -30D;
            chartArea4.AxisY.Title = "RSSI Value";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea4.CursorX.AutoScroll = false;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 88F;
            chartArea4.InnerPlotPosition.Width = 91.74339F;
            chartArea4.InnerPlotPosition.X = 8.256607F;
            chartArea4.Name = "ChartArea1";
            this.chartSend.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartSend.Legends.Add(legend4);
            this.chartSend.Location = new System.Drawing.Point(200, 89);
            this.chartSend.Name = "chartSend";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.Blue;
            series19.Legend = "Legend1";
            series19.Name = "Node 0";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            series20.Legend = "Legend1";
            series20.Name = "Node 1";
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series21.Legend = "Legend1";
            series21.Name = "Node 2";
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.Red;
            series22.Legend = "Legend1";
            series22.Name = "Node 3";
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            series23.Legend = "Legend1";
            series23.Name = "Node 4";
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series24.Legend = "Legend1";
            series24.Name = "Node 5";
            this.chartSend.Series.Add(series19);
            this.chartSend.Series.Add(series20);
            this.chartSend.Series.Add(series21);
            this.chartSend.Series.Add(series22);
            this.chartSend.Series.Add(series23);
            this.chartSend.Series.Add(series24);
            this.chartSend.Size = new System.Drawing.Size(1035, 284);
            this.chartSend.TabIndex = 19;
            this.chartSend.Text = "chart2";
            title4.Name = "Plot of RSSI Value";
            this.chartSend.Titles.Add(title4);
            // 
            // chartSendLabel
            // 
            this.chartSendLabel.AutoSize = true;
            this.chartSendLabel.BackColor = System.Drawing.Color.White;
            this.chartSendLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chartSendLabel.Location = new System.Drawing.Point(301, 89);
            this.chartSendLabel.Name = "chartSendLabel";
            this.chartSendLabel.Size = new System.Drawing.Size(156, 15);
            this.chartSendLabel.TabIndex = 20;
            this.chartSendLabel.Text = "Plot of RSSI measured ";
            this.chartSendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // selectNode
            // 
            this.selectNode.FormattingEnabled = true;
            this.selectNode.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.selectNode.Location = new System.Drawing.Point(588, 22);
            this.selectNode.Name = "selectNode";
            this.selectNode.Size = new System.Drawing.Size(88, 21);
            this.selectNode.TabIndex = 21;
            this.selectNode.SelectedIndexChanged += new System.EventHandler(this.selectNode_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(585, -1);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "Select Node";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(687, 1);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(162, 44);
            this.textBox1.TabIndex = 24;
            this.textBox1.Text = "Select a node to visualize the charts of RSSI values as received by or sent by th" +
    "at node.";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 682);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.selectNode);
            this.Controls.Add(this.chartSendLabel);
            this.Controls.Add(this.chartSend);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chartReceivLabel);
            this.Controls.Add(this.chartReceive);
            this.Controls.Add(this.endInterrupt);
            this.Controls.Add(this.startInterrupt);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.baudRateLabel);
            this.Controls.Add(this.portsLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.closePort);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.readData);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.initPort);
            this.Name = "Form1";
            this.Text = "j";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartReceive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartSend)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button initPort;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button readData;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button closePort;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label portsLabel;
        private System.Windows.Forms.Label baudRateLabel;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label errorLabel;
        private System.Windows.Forms.Button startInterrupt;
        private System.Windows.Forms.Button endInterrupt;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartReceive;
        private System.Windows.Forms.Label chartReceivLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSend;
        private System.Windows.Forms.Label chartSendLabel;
        private System.Windows.Forms.ComboBox selectNode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
    }
}

