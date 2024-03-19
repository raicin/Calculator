using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CindyWindowsApplicationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            calculate.Clear();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void one_Click(object sender, EventArgs e)
        {
            calculate.Text += "1";
        }

        private void two_Click(object sender, EventArgs e)
        {
            calculate.Text += "2";
        }

        private void three_Click(object sender, EventArgs e)
        {
            calculate.Text += "3";
        }

        private void four_Click(object sender, EventArgs e)
        {
            calculate.Text += "4";
        }

        private void zero_Click(object sender, EventArgs e)
        {
            calculate.Text += "0";
        }

        private void five_Click(object sender, EventArgs e)
        {
            calculate.Text += "5";
        }

        private void six_Click(object sender, EventArgs e)
        {
            calculate.Text += "6";
        }

        private void seven_Click(object sender, EventArgs e)
        {
            calculate.Text += "7";
        }

        private void eight_Click(object sender, EventArgs e)
        {
            calculate.Text += "8";
        }

        private void nine_Click(object sender, EventArgs e)
        {
            calculate.Text += "9";
        }

        private void equals_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var result = dt.Compute(calculate.Text, "");
                calculate.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void divide_Click(object sender, EventArgs e)
        {
            calculate.Text += "/";
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            calculate.Text += "*";
        }

        private void minus_Click(object sender, EventArgs e)
        {
            calculate.Text += "-";
        }

        private void addition_Click(object sender, EventArgs e)
        {
            calculate.Text += "+";
        }

        private void percent_Click(object sender, EventArgs e)
        {
            calculate.Text += "%";
        }

        private void period_Click(object sender, EventArgs e)
        {
            calculate.Text += ".";
        }

        private void negative_Click(object sender, EventArgs e)
        {

        }

        private void Eraseall_Click(object sender, EventArgs e)
        {
            calculate.Clear();
        }
    }
}
