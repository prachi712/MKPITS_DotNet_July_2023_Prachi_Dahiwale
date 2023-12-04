using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace radiobutton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int bal = 1000;
        private void button1_Click(object sender, EventArgs e)
        {
            int accountno = Convert.ToInt32(textBox1.Text);
            int amount = Convert.ToInt32(textBox2.Text);
            if(radioButton1.Checked)
            {
                bal = bal + amount;
            }
            else if(radioButton2.Checked)
            {
                bal = bal - amount;
            }
            label3.Text = "bal is" + bal;

        }
    }
}
