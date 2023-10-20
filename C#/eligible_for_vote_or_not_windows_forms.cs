using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eligible_for_vote_or_not_in_windows_forms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int age;
            string result;
            age = Convert.ToInt32(textBox1.Text);
            if (age >= 18)
                result = "=Eligible for Vote";
            else
            {
                result = "=not Eligible age for voting";
                label2.Text = "result" + result;
            }
        }
    }
}
