using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace userInterface_Classic
{
    public partial class Controller : Form
    {
        public Controller()
        {
            InitializeComponent();
        }


        private void Voltage_Click(object sender, EventArgs e)
        {

        }

        private void Configuration_Click(object sender, EventArgs e)
        {

        }

        private void XaxisTrackBar_Scroll(object sender, EventArgs e)
        {
            XaxisNumericUpDown1.Value = XaxisTrackBar.Value / 1000;
        }






        //Positioning Tab Begin
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
    }
}
