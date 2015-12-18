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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // initPort
            // 
            this.initPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initPort.Location = new System.Drawing.Point(443, 119);
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
            this.richTextBox1.Size = new System.Drawing.Size(159, 486);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // readData
            // 
            this.readData.Enabled = false;
            this.readData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readData.Location = new System.Drawing.Point(556, 119);
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
            this.closePort.Location = new System.Drawing.Point(684, 119);
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
            this.errorLabel.Location = new System.Drawing.Point(204, 93);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 9;
            // 
            // startInterrupt
            // 
            this.startInterrupt.Enabled = false;
            this.startInterrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInterrupt.ForeColor = System.Drawing.Color.Red;
            this.startInterrupt.Location = new System.Drawing.Point(508, 157);
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
            this.endInterrupt.Location = new System.Drawing.Point(647, 157);
            this.endInterrupt.Name = "endInterrupt";
            this.endInterrupt.Size = new System.Drawing.Size(115, 37);
            this.endInterrupt.TabIndex = 11;
            this.endInterrupt.Text = "End Interrupt";
            this.endInterrupt.UseVisualStyleBackColor = true;
            this.endInterrupt.Click += new System.EventHandler(this.endInterrupt_Click);
            // 
            // chart1
            // 
            chartArea4.AxisX.IsLabelAutoFit = false;
            chartArea4.AxisX.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisX.Title = "Packets received by the Coordinator";
            chartArea4.AxisX.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea4.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea4.AxisY.Maximum = 50D;
            chartArea4.AxisY.Minimum = -50D;
            chartArea4.AxisY.Title = "RSSI Value";
            chartArea4.AxisY.TitleFont = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            chartArea4.CursorX.AutoScroll = false;
            chartArea4.InnerPlotPosition.Auto = false;
            chartArea4.InnerPlotPosition.Height = 88F;
            chartArea4.InnerPlotPosition.Width = 91.74339F;
            chartArea4.InnerPlotPosition.X = 8.25661F;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            this.chart1.Location = new System.Drawing.Point(194, 210);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Name = "RSSI Value";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(875, 300);
            this.chart1.TabIndex = 12;
            this.chart1.Text = "chart1";
            title4.Name = "Plot of RSSI Value";
            this.chart1.Titles.Add(title4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(573, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Plot of RSSI Value";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Control;
            this.richTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox2.Location = new System.Drawing.Point(827, 9);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(226, 125);
            this.richTextBox2.TabIndex = 18;
            this.richTextBox2.Text = resources.GetString("richTextBox2.Text");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 556);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
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
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
    }
}

