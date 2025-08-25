using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace TemperatureConversion
{
    public partial class TempatureForm : Form
    {
        public TempatureForm()
        {
            InitializeComponent();
        }

        private void buttonCTF_Click(object sender, EventArgs e)
        {
            try {
                double initalCTemp = double.Parse(textBoxTemp.Text);
                double result;
                
                result = (initalCTemp * 1.8) + 32;

                labelTempture.Text = "Tempature : " + result.ToString("f2") + " F";

            }

            catch (Exception ex) {

                MessageBox.Show(ex.Message);
            
            }
            
        }

        

        private void buttonCTC_Click(object sender, EventArgs e)
        {
            try
            {
                double initalFtemp = double.Parse(textBoxTemp.Text);
                double result;

                result = (initalFtemp - 32) / 1.8;
                labelTempture.Text = "Tempature : " + result.ToString("f2") + " C";
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTemp.Text = "";

            labelTempture.Text = "Tempature : ";
        }
    }
}
