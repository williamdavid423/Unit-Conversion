using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unit_Conversion
{
      
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int amountConverted = Convert.ToInt32(textBox2.Text);
            int ConversionChoice = Convert.ToInt32(textBox1.Text);
            double Answer1 = InchtoCm(ConversionChoice, amountConverted);
            double Answer2 = FeettoCm(ConversionChoice, amountConverted);
            double Answer3 = YardtoMeters(ConversionChoice, amountConverted);
            double Answer4 = MilestoKm(ConversionChoice, amountConverted);

            if (ConversionChoice == 1)
            {
                outputLabel.Text = $"{amountConverted} inches to {Answer1} CM";
            }
            else if (ConversionChoice == 2)
            {
                outputLabel.Text = $"{amountConverted} inches to {Answer2} CM";
            }
            else if (ConversionChoice == 3)
            {
                outputLabel.Text = $"{amountConverted} Yards to {Answer3} Meters";
            }
            else if (ConversionChoice == 4)
            {
                outputLabel.Text = $"{amountConverted} Miles to {Answer4} KM";
            }
        }
        public double InchtoCm(int val1, int val2)
        {
            double convertAmount = 0;
           
            if (val1 == 1)
            {
                convertAmount = val2 * 2.54;
            }
            return convertAmount;
        }
        public double FeettoCm( int val1, int val2)
        {
            double convertAmount = 0;

            if (val1 == 2)
            {
                convertAmount = val2 * 30.48;
            }
            return convertAmount;
        }
        public double YardtoMeters(int val1, int val2)
        {
            double convertAmount = 0;

            if (val1 == 3)
            {
                convertAmount = val2 * 0.91;
            }
            return convertAmount;
        }
        public double MilestoKm(int val1, int val2)
        {
            double convertAmount = 0;

            if (val1 == 4)
            {
                convertAmount = val2 * 1.6;
            }
            return convertAmount;
        }
    }
}
