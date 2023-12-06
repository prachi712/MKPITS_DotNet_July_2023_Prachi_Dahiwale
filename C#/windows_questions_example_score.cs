using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_questions_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            int cnt = 0;
            if(radioButton1.Checked)
            {
                cnt++;
            }
            else
            {
                
            }

            if(radioButton4.Checked)
            {
                cnt++;
            }
            else
            {

            }

            if(radioButton7.Checked)
            {
                cnt++;
            }
            else
            {

            }
            
            sb.Append("score" + cnt.ToString());
            label8.Text = sb.ToString();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
