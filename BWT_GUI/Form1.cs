using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;


namespace BWT_GUI
{
    public partial class Form1 : Form
    {
        const int numTicksPerRev = 400;
        int numberOfDataPoints = 0;

        int potReading = 0;
        int potBiasTicks = 375;
        double angle = 0.0;
        double potTotalRange = 301.0;

        double emf;
        int voltageReading;
        double vref = 2.71;
        double emfOpAmpGain = 100.0;
        double potOpAmpGain = 10.0;
        double r_w; // current value is 0.51 ohm
        double r_l; // current value is 1.1 ohm
        

        //string filepath = @"C:\Course Material\Mech 4\Mech 45X\Test Runs\TestRunBWT.csv";
        string filepath = "";
        string filepathCombined = "";
        
        // Data Read variables
        int potMSByte;
        int potLSByte;
        int voltageMSByte;
        int voltageLSByte;

        int currState = 0;
        int currentByte = 0;

        double timeTracker = 0.0;
        double timeNow;
        double timeInterval = 0.025;

        bool saveDataFlag = false;
        bool currentTimeSaved = false;

        List<double> velocityList = new List<double>();
        byte[] TxBytes = new Byte[3];


        public Form1()
        {
            InitializeComponent();
        }

        // update the list of com ports available for connection
        private void ComPortUpdate()
        {
            cmbComPort.Items.Clear();
            string[] comPortArray = System.IO.Ports.SerialPort.GetPortNames().ToArray();
            Array.Reverse(comPortArray);
            cmbComPort.Items.AddRange(comPortArray);
            if (cmbComPort.Items.Count != 0)
                cmbComPort.SelectedIndex = 0;
            else
                cmbComPort.Text = "No Ports Found!";
        }

        // load the Form
        private void Form1_Load(object sender, EventArgs e)
        {
            lblIncomingDataRate.Visible = false;
            chkShowResponse.Checked = true;
            ComPortUpdate();
        }

        // connect to the com port source 
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (btnConnect.Text == "Connect")
            {
                if (cmbComPort.Items.Count > 0)
                {
                    try
                    {
                        serialPort1.BaudRate = Convert.ToInt16(txtBaudRate.Text);
                        serialPort1.PortName = cmbComPort.SelectedItem.ToString();
                        serialPort1.Open();
                        btnConnect.Text = "Disconnect";
                        timer1.Enabled = true;
                        velocityTimer.Enabled = true;
                        lblIncomingDataRate.Visible = true;
                        timeTracker = 0.0;                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }   
            }
            else
            {
                try
                {
                    serialPort1.Close();
                    btnConnect.Text = "Connect";
                    timer1.Enabled = false;
                    velocityTimer.Enabled = false;
                    lblIncomingDataRate.Visible = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        // Read the incoming 16 bit voltage and emf data from Arduino  
        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            while (serialPort1.IsOpen && serialPort1.BytesToRead != 0)
            {

                currentByte = serialPort1.ReadByte();

                //if current state is 0, then MSB is received
                if (currentByte == 255 && currState == 0)
                {
                    currState = 1;
                }
                else if (currState == 1)
                {
                    potMSByte = currentByte << 8;
                    currState = 2;
                }
                else if (currState == 2)
                {
                    potLSByte = currentByte;
                    potReading = potMSByte + potLSByte;
                    currState = 0;
                }

                else if (currentByte == 254 && currState == 0)
                {
                    currState = 3;
                }
                else if (currState == 3)
                {
                    voltageMSByte = currentByte << 8;
                    currState = 4;
                }
                else if (currState == 4)
                {
                    voltageLSByte = currentByte;
                    voltageReading = voltageMSByte + voltageLSByte;
                    currState = 0;
                }

                if (chkShowResponse.Checked)
                    this.BeginInvoke(new EventHandler(delegate
                    {
                        txtRawSerial.AppendText(currentByte.ToString() + ", ");
                    }));
            }

        }

        /// <summary>
        /// Creates a plot of the incoming position and emf data
        /// </summary>
        /// <param name="position"></param>
        /// <param name="emf"></param>
        private void updatePlot(double positionChart, double emfChart)
        {
            //plotPosition.Series["Position [deg]"].Points.AddY(positionChart);
            plotPosition.Series["Position [deg]"].Points.AddY(positionChart);
            plotPosition.Series["Induced EMF [mV]"].Points.AddY(emfChart);

            //plotPosition.Series["Position [deg]"].Points.AddX(time);`
            plotPosition.ChartAreas[0].AxisX.Interval = 10;
            plotPosition.ChartAreas[0].AxisY.Interval = 5;
            plotPosition.ChartAreas[0].AxisY.Maximum = 25;
            plotPosition.ChartAreas[0].AxisY.Minimum = -25;

            if (plotPosition.Series["Position [deg]"].Points.Count > 50)
            {
                plotPosition.Series["Position [deg]"].Points.RemoveAt(0);
                plotPosition.Series["Induced EMF [mV]"].Points.RemoveAt(0);

            }
        }

        // displays the incoming data rate to user every 1 second
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblIncomingDataRate.Text = "Incoming data rate = " + numberOfDataPoints.ToString() + " bytes per second";
            numberOfDataPoints = 0;
        }

        // processes the incoming data and updates the plot every 25ms (Windows time)
        private void velocityTimer_Tick(object sender, EventArgs e)
        {
            



            //compute angular position in degrees and emf in mV            
            angle = ((double)potReading - potBiasTicks)/ potOpAmpGain * potTotalRange/1024.0;       
            angle = Math.Round(angle, 4);   
            //emf = ((double)voltageReading / 1023.0 * 5.0 - vref) / emfOpAmpGain * (r_w + r_l)/r_l * 1000.0; // [mV]
            emf = ((double)voltageReading / 1023.0 * 5.0 - vref) / emfOpAmpGain * 1000.0; // [mV]
            emf = Math.Round(emf, 5);
            

            txtPosition.Text = angle.ToString();
            txtEMF.Text = emf.ToString();           

            updatePlot(angle, emf);

            // saves the actual time elapsed by reading the real time before saving the data in the file
            if (saveDataFlag == true)
            {
                if(currentTimeSaved == false)
                {
                    timeNow = DateTime.Now.TimeOfDay.TotalMilliseconds;
                    currentTimeSaved = true;
                }
                else
                {
                    try
                    {
                        timeTracker = DateTime.Now.TimeOfDay.TotalMilliseconds - timeNow;
                        string csv = string.Format("{0},{1},{2}\n", timeTracker, angle, emf);
                        File.AppendAllText(filepathCombined, csv);
                    }
                    catch
                    {
                        MessageBox.Show("Error Occured", "Save Error");
                    }
                }
                
            }        
            
        }

        // Enables the incoming data to be saved in a .csv file
        private void btSaveData_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtFileName.Text) == false)
            {
                string[] paths = { @"", filepath.ToString(), txtFileName.Text.ToString() };
                filepathCombined = Path.Combine(paths);
                var myFile = File.Create(filepathCombined);
                myFile.Close();

                lbSave.Visible = true;
                saveDataFlag = true;
                timeTracker = 0.0;

                // Save the values of wire and load resistances in the spreadsheet
                string csv = string.Format("{0},{1},{2}\n", "R_W", txtRw.Text.ToString(), "ohm");
                File.AppendAllText(filepathCombined, csv);
                csv = string.Format("{0},{1},{2}\n", "R_L", txtRL.Text.ToString(), "ohm");
                File.AppendAllText(filepathCombined, csv);

            }
            
        }

        // stops the saving of .csv file
        private void btStopSaving_Click(object sender, EventArgs e)
        {
            saveDataFlag = false;
            lbSave.Visible = false;
            timeTracker = 0.0;
            currentTimeSaved = false;
        }
        
        // enables the user to browse to a certain folder to save the csv file in
        private void btBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filepath = folderBrowserDialog1.SelectedPath;
                tbFolderLocation.Text = filepath;
                btSaveData.Enabled = true;
                btStopSaving.Enabled = true;
            }
        }


        // enables the user to provide positive bias to the voltage and emf data so that it is zero when the turbine is at rest
        private void btUp_Click(object sender, EventArgs e)
        {
            if(rbPosition.Checked)
            {
                potBiasTicks--;
            }

            if (rbEMF.Checked)
            {
                vref -= 0.01;
            }
        }

        // enables the user to provide negative bias to the voltage and emf data so that it is zero when the turbine is at rest
        private void btDown_Click(object sender, EventArgs e)
        {
            if (rbPosition.Checked)
            {
                potBiasTicks++;
            }

            if (rbEMF.Checked)
            {
                vref += 0.01;
            }
        }
    }
}

    