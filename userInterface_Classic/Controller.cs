using System;
using System.Windows.Forms;



namespace userInterface_Classic
{
    public partial class Controller : Form
    {


        bool temperatureEnabled = false;
        bool voltageEnabled = false;
        bool pressureEnabled = false;
        bool positionEnabled = false;



        public Controller()
        {
            InitializeComponent();
            UpdateViews();
        }




        private void Voltage_Click(object sender, EventArgs e)
        {

        }

        private void Configuration_Click(object sender, EventArgs e)
        {

        }


        //Positioning Tab Begin

        private void XaxisTrackBar_Scroll(object sender, EventArgs e)
        {
            XaxisNumericUpDown1.Value = XaxisTrackBar.Value / 1000;
        }
        private void XaxisNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            XaxisTrackBar.Value = (int)(XaxisNumericUpDown1.Value * 1000);
        }

        private void XaxisSetButton_Click(object sender, EventArgs e)
        {
            if (Stage1radioButton.Checked)
            {
                curentPositionStage1Xlabel.Text = XaxisNumericUpDown1.Value.ToString();
            }

            else if (Stage2radioButton.Checked)
            {
                curentPositionStage2Xlabel.Text = XaxisNumericUpDown1.Value.ToString();
            }

            else if (Stage3radioButton.Checked)
            {
                curentPositionStage3Xlabel.Text = XaxisNumericUpDown1.Value.ToString();
            }
        }

        private void YaxisSetButton_Click(object sender, EventArgs e)
        {
            if (Stage1radioButton.Checked)
            {
                curentPositionStage1Ylabel.Text = YaxisNumericUpDown1.Value.ToString();
            }

            else if (Stage2radioButton.Checked)
            {
                curentPositionStage2Ylabel.Text = YaxisNumericUpDown1.Value.ToString();
            }

            else if (Stage3radioButton.Checked)
            {
                curentPositionStage3Ylabel.Text = YaxisNumericUpDown1.Value.ToString();
            }
        }

        private void YaxisNumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            YaxisTrackBar.Value = (int)(YaxisNumericUpDown1.Value * 1000);

        }

        private void YaxisTrackBar_Scroll(object sender, EventArgs e)
        {
            YaxisNumericUpDown1.Value = YaxisTrackBar.Value / 1000;
        }

        private void InitializeButton4_Click(object sender, EventArgs e)
        {

        }


        //Positioning Tab End


        //Pressure Tab Begin

        private void SetZonePressureButton2_Click(object sender, EventArgs e)
        {
            if (zone1EnableCheckBox5.Checked)
            {
                zone1SetLabel.Text = zone1NumericUpDown3.Value.ToString();
            }
            if (zone2EnableCheckBox4.Checked)
            {
                zone2SetLabel.Text = Zone2umericUpDown4.Value.ToString();
            }
        }

        private void ResetZonePressureButton1_Click(object sender, EventArgs e)
        {
            Zone2umericUpDown4.Value = zone1NumericUpDown3.Value = 0;
            zone1SetLabel.Text = zone1NumericUpDown3.Value.ToString();
            zone2SetLabel.Text = Zone2umericUpDown4.Value.ToString();
        }
        //Pressure Tab End

        //Voltage Tab Begin

        private void VoltageSetButton_Click(object sender, EventArgs e)
        {
            if (VoltCheckBox1.Checked)
            {
                PSUSetVoltLabel1.Text = voltNumericUpDown1.Value.ToString();
            }
            if (VoltCheckBox2.Checked)
            {
                PSUSetVoltLabel2.Text = voltNumericUpDown2.Value.ToString();
            }
            if (VoltCheckBox3.Checked)
            {
                PSUSetVoltLabel3.Text = voltNumericUpDown3.Value.ToString();
            }
            if (VoltCheckBox4.Checked)
            {
                PSUSetVoltLabel4.Text = voltNumericUpDown4.Value.ToString();
            }
            if (VoltCheckBox5.Checked)
            {
                PSUSetVoltLabel5.Text = voltNumericUpDown5.Value.ToString();
            }
            if (VoltCheckBox6.Checked)
            {
                PSUSetVoltLabel6.Text = voltNumericUpDown6.Value.ToString();
            }

        }

        private void VoltageResetButton_Click(object sender, EventArgs e)
        {
            voltNumericUpDown1.Value = voltNumericUpDown2.Value = voltNumericUpDown3.Value = voltNumericUpDown4.Value = voltNumericUpDown5.Value = voltNumericUpDown6.Value = 0;
            PSUSetVoltLabel1.Text = PSUSetVoltLabel2.Text = PSUSetVoltLabel3.Text = PSUSetVoltLabel4.Text = PSUSetVoltLabel5.Text = PSUSetVoltLabel6.Text = "0.000";
        }

        //Voltage Tab End

        //Temperature Tab Begin

        private void SetTemperatureButton_Click(object sender, EventArgs e)
        {
            if (heater1EnablecheckBox.Checked)
            {
                heaterSetLabel1.Text = heater1TempNumericUpDown.Value.ToString("0.0");
            }
            if (heater2EnablecheckBox.Checked)
            {
                heaterSetLabel2.Text = heater2TempNumericUpDown.Value.ToString("0.0");
            }
            if (heater3EnablecheckBox.Checked)
            {
                heaterSetLabel3.Text = heater3TempNumericUpDown.Value.ToString("0.0");
            }
        }

        private void ResetTemperatureButton_Click(object sender, EventArgs e)
        {
            heater3TempNumericUpDown.Value = heater1TempNumericUpDown.Value = heater2TempNumericUpDown.Value = (decimal)18.0;
            heaterSetLabel1.Text = heaterSetLabel2.Text = heaterSetLabel3.Text = "18.0";
        }

        //Temperature Tab End

        private void Button3_Click(object sender, EventArgs e)
        {
            if (VoltageControlCheckBox.Checked)
            {
                voltageEnabled = true;
            }
            else
            {
                voltageEnabled = false;
            }
            if (pressureControlCheckBox.Checked)
            {
                pressureEnabled = true;
            }
            else
            {
                pressureEnabled = false;
            }

            if (positionControlCheckBox.Checked)
            {
                positionEnabled = true;
            }
            else
            {
                positionEnabled = false;
            }

            if (TemperaureControlCheckBox.Checked)
            {
                temperatureEnabled = true;
            }
            else
            {
                temperatureEnabled = false;
            }

            UpdateViews();
        }

        void UpdateViews()
        {
            ((Control)this.Temperature).Enabled = temperatureEnabled;
            ((Control)this.Pressure).Enabled = pressureEnabled;
            ((Control)this.Voltage).Enabled = voltageEnabled;
            ((Control)this.Positioning).Enabled = positionEnabled;
        }

        void DisableAll()
        {
            ((Control)this.Temperature).Enabled = false;
            ((Control)this.Pressure).Enabled = false;
            ((Control)this.Voltage).Enabled = false;
            ((Control)this.Positioning).Enabled = false;
        }
    }
}
