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
            double endConversion = ConvertNumber(ConversionChoice, amountConverted);

            outputLabel.Text = $"{endConversion}";
        }
        public double ConvertNumber(int val1, int val2)
        {
            double convertAmount = 0;
            string length;
            string endLength;
            if (val1 == 1)
            {
                convertAmount = val2 * 2.54;
                length = "Inches";
                endLength = "CM";
            }
            else if (val1 == 2)
            {
               
                convertAmount = val2 * 30.48;
                length = "Feet";
                endLength = "CM";
            }
            else if (val1 == 3)
            {
               convertAmount = val2 * 0.91;
                length = "Yards";
                endLength = "Meters";
            }
            else if (val1 == 4)
            {
                convertAmount = val2 * 1.6;
                length = "Miles";
                endLength = "km";
            }
            return convertAmount;
        }
    }
}
