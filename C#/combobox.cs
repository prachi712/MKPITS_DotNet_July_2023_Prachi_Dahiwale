using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string empname = textBox1.Text;
            int bsal = Convert.ToInt32(textBox2.Text);
            string designation = comboBox1.Text;
            float bonus = 0.0f;
            float totalsal = 0.0f;
            label4.Text = "";
            label5.Text = "";
            switch(designation)
            {
                case "manager":
                    bonus = bsal * 0.055f;
                    break;
                case "clerk":
                    bonus = bsal * 0.45f;
                    break;
                case "peun":
                    bonus = bsal * 0.25f;
                    break;
            }
            totalsal = bsal + bonus;
            if(checkBox1.Checked)
                    {

                    label4.Text = "bonus" + bonus;
                }
                if(checkBox2.Checked)
                {
                    label5.Text = "total sal" + totalsal;
                }
        }
    }
}
