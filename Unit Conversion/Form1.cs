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
            ConvertNumber(ConversionChoice, amountConverted);
        }
        public void ConvertNumber(int val1, int val2)
        {
            double inchConvert = val2 * 2.54;
            if (val1 == 1)
            {
                outputLabel.Text = $"{inchConvert}";
            }

        }
    }
}
