using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Name: Matthew Amorelli

// Date: 9/18/2021

// Assignment: Tempature Converter (Chapter 3 - Exercise 2)

// Description: a simple tempature Conversion betwen Celsius to Fahrenheit and Fahrenheit to Celsius,
//when the user clicks the button Celsius to Fahrenheit after the user enders the  Celsius tempature, it converts to 
//Fahrenheit, and when the user clicks the button "Fahrenheit to  Celsius" after the user enters the Fahrenheit,
// it is converted to Celsius.

//Even though this was a exersise, this exersise is dedicated for my Grandma's old tempature clock as its quite older than I am
//and doesnt work



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
