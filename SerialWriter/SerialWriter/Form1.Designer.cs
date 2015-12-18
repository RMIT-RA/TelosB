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
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            // 
            // initPort
            // 
            this.initPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initPort.Location = new System.Drawing.Point(208, 252);
            this.initPort.Name = "initPort";
            this.initPort.Size = new System.Drawing.Size(106, 32);
            this.initPort.TabIndex = 0;
            this.initPort.Text = "Init Port";
            this.initPort.UseVisualStyleBackColor = true;
            this.initPort.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(30, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(159, 396);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // readData
            // 
            this.readData.Enabled = false;
            this.readData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readData.Location = new System.Drawing.Point(355, 252);
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
            this.statusLabel.Location = new System.Drawing.Point(204, 78);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // closePort
            // 
            this.closePort.Enabled = false;
            this.closePort.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closePort.Location = new System.Drawing.Point(507, 252);
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
            this.comboBox1.Location = new System.Drawing.Point(207, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // portsLabel
            // 
            this.portsLabel.AutoSize = true;
            this.portsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.portsLabel.Location = new System.Drawing.Point(204, 21);
            this.portsLabel.Name = "portsLabel";
            this.portsLabel.Size = new System.Drawing.Size(102, 17);
            this.portsLabel.TabIndex = 6;
            this.portsLabel.Text = "Available Ports";
            // 
            // baudRateLabel
            // 
            this.baudRateLabel.AutoSize = true;
            this.baudRateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.baudRateLabel.Location = new System.Drawing.Point(402, 21);
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
            this.comboBox2.Location = new System.Drawing.Point(405, 41);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 8;
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(204, 165);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 20);
            this.errorLabel.TabIndex = 9;
            // 
            // startInterrupt
            // 
            this.startInterrupt.Enabled = false;
            this.startInterrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startInterrupt.ForeColor = System.Drawing.Color.Red;
            this.startInterrupt.Location = new System.Drawing.Point(207, 325);
            this.startInterrupt.Name = "startInterrupt";
            this.startInterrupt.Size = new System.Drawing.Size(141, 55);
            this.startInterrupt.TabIndex = 10;
            this.startInterrupt.Text = "Start Interrupt";
            this.startInterrupt.UseVisualStyleBackColor = true;
            this.startInterrupt.Click += new System.EventHandler(this.button4_Click);
            // 
            // endInterrupt
            // 
            this.endInterrupt.Enabled = false;
            this.endInterrupt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endInterrupt.ForeColor = System.Drawing.Color.Blue;
            this.endInterrupt.Location = new System.Drawing.Point(383, 325);
            this.endInterrupt.Name = "endInterrupt";
            this.endInterrupt.Size = new System.Drawing.Size(121, 55);
            this.endInterrupt.TabIndex = 11;
            this.endInterrupt.Text = "End Interrupt";
            this.endInterrupt.UseVisualStyleBackColor = true;
            this.endInterrupt.Click += new System.EventHandler(this.endInterrupt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 402);
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
    }
}

