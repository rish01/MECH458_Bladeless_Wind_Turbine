namespace BWT_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.cmbComPort = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtBaudRate = new System.Windows.Forms.ToolStripTextBox();
            this.btnConnect = new System.Windows.Forms.ToolStripButton();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.chkShowResponse = new System.Windows.Forms.CheckBox();
            this.txtRawSerial = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblIncomingDataRate = new System.Windows.Forms.Label();
            this.txtPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.velocityTimer = new System.Windows.Forms.Timer(this.components);
            this.plotPosition = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.positionCorrectionTimer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtEMF = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.btSaveData = new System.Windows.Forms.Button();
            this.btStopSaving = new System.Windows.Forms.Button();
            this.lbSave = new System.Windows.Forms.Label();
            this.btBrowseFolder = new System.Windows.Forms.Button();
            this.tbFolderLocation = new System.Windows.Forms.TextBox();
            this.rbPosition = new System.Windows.Forms.RadioButton();
            this.rbEMF = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lbRL = new System.Windows.Forms.Label();
            this.txtRL = new System.Windows.Forms.TextBox();
            this.lbOhm = new System.Windows.Forms.Label();
            this.btDown = new System.Windows.Forms.Button();
            this.btUp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRw = new System.Windows.Forms.TextBox();
            this.lbRw = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cmbComPort,
            this.toolStripLabel1,
            this.txtBaudRate,
            this.btnConnect});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 28);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // cmbComPort
            // 
            this.cmbComPort.Name = "cmbComPort";
            this.cmbComPort.Size = new System.Drawing.Size(159, 28);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(80, 25);
            this.toolStripLabel1.Text = "Baud Rate:";
            // 
            // txtBaudRate
            // 
            this.txtBaudRate.Name = "txtBaudRate";
            this.txtBaudRate.Size = new System.Drawing.Size(92, 28);
            this.txtBaudRate.Text = "9600";
            // 
            // btnConnect
            // 
            this.btnConnect.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnConnect.Image = ((System.Drawing.Image)(resources.GetObject("btnConnect.Image")));
            this.btnConnect.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(67, 25);
            this.btnConnect.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // chkShowResponse
            // 
            this.chkShowResponse.AutoSize = true;
            this.chkShowResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowResponse.Location = new System.Drawing.Point(16, 294);
            this.chkShowResponse.Margin = new System.Windows.Forms.Padding(4);
            this.chkShowResponse.Name = "chkShowResponse";
            this.chkShowResponse.Size = new System.Drawing.Size(252, 29);
            this.chkShowResponse.TabIndex = 2;
            this.chkShowResponse.Text = "Response from Com Port";
            this.chkShowResponse.UseVisualStyleBackColor = true;
            // 
            // txtRawSerial
            // 
            this.txtRawSerial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtRawSerial.Location = new System.Drawing.Point(16, 325);
            this.txtRawSerial.Margin = new System.Windows.Forms.Padding(4);
            this.txtRawSerial.Multiline = true;
            this.txtRawSerial.Name = "txtRawSerial";
            this.txtRawSerial.ReadOnly = true;
            this.txtRawSerial.Size = new System.Drawing.Size(291, 24);
            this.txtRawSerial.TabIndex = 4;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblIncomingDataRate
            // 
            this.lblIncomingDataRate.AutoSize = true;
            this.lblIncomingDataRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblIncomingDataRate.Location = new System.Drawing.Point(19, 356);
            this.lblIncomingDataRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIncomingDataRate.Name = "lblIncomingDataRate";
            this.lblIncomingDataRate.Size = new System.Drawing.Size(255, 18);
            this.lblIncomingDataRate.TabIndex = 1;
            this.lblIncomingDataRate.Text = "Incoming Data Rate = 0 bytes/second";
            // 
            // txtPosition
            // 
            this.txtPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPosition.Location = new System.Drawing.Point(121, 599);
            this.txtPosition.Name = "txtPosition";
            this.txtPosition.ReadOnly = true;
            this.txtPosition.Size = new System.Drawing.Size(129, 30);
            this.txtPosition.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label4.Location = new System.Drawing.Point(21, 603);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 24);
            this.label4.TabIndex = 11;
            this.label4.Text = "Position";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label6.Location = new System.Drawing.Point(256, 603);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "deg";
            // 
            // velocityTimer
            // 
            this.velocityTimer.Interval = 25;
            this.velocityTimer.Tick += new System.EventHandler(this.velocityTimer_Tick);
            // 
            // plotPosition
            // 
            this.plotPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea1.Name = "ChartArea1";
            this.plotPosition.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.plotPosition.Legends.Add(legend1);
            this.plotPosition.Location = new System.Drawing.Point(339, 161);
            this.plotPosition.Name = "plotPosition";
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Position [deg]";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.LabelBorderWidth = 2;
            series2.Legend = "Legend1";
            series2.Name = "Induced EMF [mV]";
            this.plotPosition.Series.Add(series1);
            this.plotPosition.Series.Add(series2);
            this.plotPosition.Size = new System.Drawing.Size(705, 505);
            this.plotPosition.TabIndex = 20;
            this.plotPosition.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.Location = new System.Drawing.Point(256, 641);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 24);
            this.label2.TabIndex = 23;
            this.label2.Text = "mV";
            // 
            // txtEMF
            // 
            this.txtEMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEMF.Location = new System.Drawing.Point(121, 635);
            this.txtEMF.Name = "txtEMF";
            this.txtEMF.ReadOnly = true;
            this.txtEMF.Size = new System.Drawing.Size(129, 30);
            this.txtEMF.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.Location = new System.Drawing.Point(21, 639);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 24);
            this.label3.TabIndex = 21;
            this.label3.Text = "EMF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(335, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Test File Name (add .csv to filename)";
            // 
            // txtFileName
            // 
            this.txtFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFileName.Location = new System.Drawing.Point(16, 81);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(291, 30);
            this.txtFileName.TabIndex = 25;
            // 
            // btSaveData
            // 
            this.btSaveData.Enabled = false;
            this.btSaveData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSaveData.Location = new System.Drawing.Point(16, 161);
            this.btSaveData.Name = "btSaveData";
            this.btSaveData.Size = new System.Drawing.Size(143, 37);
            this.btSaveData.TabIndex = 26;
            this.btSaveData.Text = "Save Data";
            this.btSaveData.UseVisualStyleBackColor = true;
            this.btSaveData.Click += new System.EventHandler(this.btSaveData_Click);
            // 
            // btStopSaving
            // 
            this.btStopSaving.Enabled = false;
            this.btStopSaving.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStopSaving.Location = new System.Drawing.Point(165, 161);
            this.btStopSaving.Name = "btStopSaving";
            this.btStopSaving.Size = new System.Drawing.Size(142, 37);
            this.btStopSaving.TabIndex = 27;
            this.btStopSaving.Text = "Stop Saving";
            this.btStopSaving.UseVisualStyleBackColor = true;
            this.btStopSaving.Click += new System.EventHandler(this.btStopSaving_Click);
            // 
            // lbSave
            // 
            this.lbSave.AutoSize = true;
            this.lbSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSave.Location = new System.Drawing.Point(15, 212);
            this.lbSave.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbSave.Name = "lbSave";
            this.lbSave.Size = new System.Drawing.Size(108, 25);
            this.lbSave.TabIndex = 28;
            this.lbSave.Text = "Saving in...";
            this.lbSave.Visible = false;
            // 
            // btBrowseFolder
            // 
            this.btBrowseFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBrowseFolder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBrowseFolder.Location = new System.Drawing.Point(16, 118);
            this.btBrowseFolder.Name = "btBrowseFolder";
            this.btBrowseFolder.Size = new System.Drawing.Size(291, 37);
            this.btBrowseFolder.TabIndex = 29;
            this.btBrowseFolder.Text = "Browse Folder";
            this.btBrowseFolder.UseVisualStyleBackColor = true;
            this.btBrowseFolder.Click += new System.EventHandler(this.btBrowseFolder_Click);
            // 
            // tbFolderLocation
            // 
            this.tbFolderLocation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.tbFolderLocation.Location = new System.Drawing.Point(16, 245);
            this.tbFolderLocation.Margin = new System.Windows.Forms.Padding(4);
            this.tbFolderLocation.Name = "tbFolderLocation";
            this.tbFolderLocation.ReadOnly = true;
            this.tbFolderLocation.Size = new System.Drawing.Size(288, 24);
            this.tbFolderLocation.TabIndex = 30;
            // 
            // rbPosition
            // 
            this.rbPosition.AutoSize = true;
            this.rbPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rbPosition.Location = new System.Drawing.Point(22, 520);
            this.rbPosition.Name = "rbPosition";
            this.rbPosition.Size = new System.Drawing.Size(97, 28);
            this.rbPosition.TabIndex = 33;
            this.rbPosition.TabStop = true;
            this.rbPosition.Text = "Position";
            this.rbPosition.UseVisualStyleBackColor = true;
            // 
            // rbEMF
            // 
            this.rbEMF.AutoSize = true;
            this.rbEMF.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.rbEMF.Location = new System.Drawing.Point(22, 552);
            this.rbEMF.Name = "rbEMF";
            this.rbEMF.Size = new System.Drawing.Size(72, 28);
            this.rbEMF.TabIndex = 34;
            this.rbEMF.TabStop = true;
            this.rbEMF.Text = "EMF";
            this.rbEMF.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(19, 487);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 35;
            this.label1.Text = "BIAS";
            // 
            // lbRL
            // 
            this.lbRL.AutoSize = true;
            this.lbRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbRL.Location = new System.Drawing.Point(20, 439);
            this.lbRL.Name = "lbRL";
            this.lbRL.Size = new System.Drawing.Size(149, 24);
            this.lbRL.TabIndex = 38;
            this.lbRL.Text = "Load Resistance";
            // 
            // txtRL
            // 
            this.txtRL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRL.Location = new System.Drawing.Point(175, 437);
            this.txtRL.Name = "txtRL";
            this.txtRL.Size = new System.Drawing.Size(75, 30);
            this.txtRL.TabIndex = 39;
            // 
            // lbOhm
            // 
            this.lbOhm.AutoSize = true;
            this.lbOhm.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbOhm.Location = new System.Drawing.Point(256, 439);
            this.lbOhm.Name = "lbOhm";
            this.lbOhm.Size = new System.Drawing.Size(48, 24);
            this.lbOhm.TabIndex = 40;
            this.lbOhm.Text = "ohm";
            // 
            // btDown
            // 
            this.btDown.BackgroundImage = global::BWT_GUI.Properties.Resources.down_arrow;
            this.btDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btDown.Location = new System.Drawing.Point(190, 520);
            this.btDown.Name = "btDown";
            this.btDown.Size = new System.Drawing.Size(60, 58);
            this.btDown.TabIndex = 37;
            this.btDown.UseVisualStyleBackColor = true;
            this.btDown.Click += new System.EventHandler(this.btDown_Click);
            // 
            // btUp
            // 
            this.btUp.BackgroundImage = global::BWT_GUI.Properties.Resources.up_arrow;
            this.btUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUp.Location = new System.Drawing.Point(121, 520);
            this.btUp.Name = "btUp";
            this.btUp.Size = new System.Drawing.Size(60, 58);
            this.btUp.TabIndex = 36;
            this.btUp.UseVisualStyleBackColor = true;
            this.btUp.Click += new System.EventHandler(this.btUp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackgroundImage = global::BWT_GUI.Properties.Resources.Capstone_Logo;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(587, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(271, 103);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label7.Location = new System.Drawing.Point(256, 402);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 24);
            this.label7.TabIndex = 43;
            this.label7.Text = "ohm";
            // 
            // txtRw
            // 
            this.txtRw.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtRw.Location = new System.Drawing.Point(175, 400);
            this.txtRw.Name = "txtRw";
            this.txtRw.Size = new System.Drawing.Size(75, 30);
            this.txtRw.TabIndex = 42;
            // 
            // lbRw
            // 
            this.lbRw.AutoSize = true;
            this.lbRw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.lbRw.Location = new System.Drawing.Point(20, 402);
            this.lbRw.Name = "lbRw";
            this.lbRw.Size = new System.Drawing.Size(146, 24);
            this.lbRw.TabIndex = 41;
            this.lbRw.Text = "Wire Resistance";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 683);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRw);
            this.Controls.Add(this.lbRw);
            this.Controls.Add(this.lbOhm);
            this.Controls.Add(this.txtRL);
            this.Controls.Add(this.lbRL);
            this.Controls.Add(this.btDown);
            this.Controls.Add(this.btUp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rbEMF);
            this.Controls.Add(this.rbPosition);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbFolderLocation);
            this.Controls.Add(this.btBrowseFolder);
            this.Controls.Add(this.lbSave);
            this.Controls.Add(this.btStopSaving);
            this.Controls.Add(this.btSaveData);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEMF);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.plotPosition);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPosition);
            this.Controls.Add(this.chkShowResponse);
            this.Controls.Add(this.lblIncomingDataRate);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.txtRawSerial);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1074, 730);
            this.Name = "Form1";
            this.Text = "Bladeless Wind Turbine GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.plotPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripComboBox cmbComPort;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtBaudRate;
        private System.Windows.Forms.ToolStripButton btnConnect;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.CheckBox chkShowResponse;
        private System.Windows.Forms.TextBox txtRawSerial;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblIncomingDataRate;
        private System.Windows.Forms.TextBox txtPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer velocityTimer;
        private System.Windows.Forms.DataVisualization.Charting.Chart plotPosition;
        private System.Windows.Forms.Timer positionCorrectionTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEMF;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button btSaveData;
        private System.Windows.Forms.Button btStopSaving;
        private System.Windows.Forms.Label lbSave;
        private System.Windows.Forms.Button btBrowseFolder;
        private System.Windows.Forms.TextBox tbFolderLocation;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbPosition;
        private System.Windows.Forms.RadioButton rbEMF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btUp;
        private System.Windows.Forms.Button btDown;
        private System.Windows.Forms.Label lbRL;
        private System.Windows.Forms.TextBox txtRL;
        private System.Windows.Forms.Label lbOhm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRw;
        private System.Windows.Forms.Label lbRw;
    }
}

