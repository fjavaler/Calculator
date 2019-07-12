using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class Calculator : Form
    {
        private string operation = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CalcText.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CalcText.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            CalcText.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            CalcText.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            CalcText.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            CalcText.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            CalcText.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            CalcText.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            CalcText.Text += "9";
        }

        private void Button0_Click(object sender, EventArgs e)
        {
            CalcText.Text += "0";
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            CalcText.Text = "";
        }

        private void PositiveNegativeButton_Click(object sender, EventArgs e)
        {

        }

        private void PercentageButton_Click(object sender, EventArgs e)
        {

        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            operation = "/";
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            operation = "*";
        }

        private void SubtractionButton_Click(object sender, EventArgs e)
        {
            operation = "-";
        }

        private void AdditionButton_Click(object sender, EventArgs e)
        {
            operation = "+";
        }

        private void EqualsButton_Click(object sender, EventArgs e)
        {

        }

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            if (CalcText.Text.Contains("."))
            {

            }
            else
            {
                CalcText.Text += ".";
            }
        }
    }
}
