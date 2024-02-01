using System;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string CalTotal;
        double num1;
        double num2;
        string option;
        double result;

        private void n6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void n0_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";
        }

        private void n1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void n2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";
        }

        private void n3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";
        }

        private void n4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";
        }

        private void n5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";
        }

        private void n7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";
        }

        private void n8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";
        }

        private void n9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";
        }

        private void plus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();

        }

        private void minus_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void multi_Click(object sender, EventArgs e)
        {
            option = "x";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void div_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = double.Parse(textBox1.Text);

            textBox1.Clear();
        }

        private void equal_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("x"))
                result = num1 * num2;

            if (option.Equals("/"))
            {
                if (num2 != 0)
                    result = num1 / num2;
                else
                    textBox1.Text = "Cannot divide by zero";
            }

            textBox1.Text = result.ToString();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            result = 0;
            num1 = 0;
            num2 = 0;
        }

        private void point_Click_1(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
                textBox1.Text = textBox1.Text + ".";
        }
    }
}
