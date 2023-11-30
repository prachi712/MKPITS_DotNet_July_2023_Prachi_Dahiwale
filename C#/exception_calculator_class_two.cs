using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exception_calculator_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        calculator c = new calculator();
        private void button1_Click(object sender, EventArgs e)
        {
            int r = c.Addition(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "addition of numbers is: " + r;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int r = c.Substraction(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "substraction of numbers is: " + r;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int r = c.Multiplication(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "multiplication of numbers is: " + r;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int r = c.Division(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));

            label3.Text = "Division of numbers is: " + r;
        }
    }
}   
