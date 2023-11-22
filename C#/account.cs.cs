using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace abstract_account
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            abstract_class_account acount = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox1.Text);
            string tt = textBox3.Text;
            if (tt == "saving")
            {
                acount = new saving();
            }
            else if(tt=="current")
            {
                acount = new current(); 
            }
            label4.Text = acount.deposit(actno, amt);
            label5.Text = acount.showbalance();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            abstract_class_account acount = null;
            int actno = Convert.ToInt32(textBox1.Text);
            int amt = Convert.ToInt32(textBox1.Text);
            string tt = textBox3.Text;
            if (tt == "saving")
            {
                acount = new saving();
            }
            else if (tt == "current")
            {
                acount = new current();
            }
            label4.Text = acount.withdraw(actno, amt);
            label5.Text = acount.showbalance();
        }
    }
}
