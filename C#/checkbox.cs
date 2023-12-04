using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace checkbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);


            float bonus = bsal * 0.40f;
            float totalsal = bsal + bonus;
            label3.Text = "";
            label4.Text = "";
            if (checkBox1.Checked)
            {
                label3.Text = "bonus" + bonus;
            }
            if (checkBox2.Checked)
            {
                label4.Text = "total salary" + totalsal;
            }

        }
    }
}
