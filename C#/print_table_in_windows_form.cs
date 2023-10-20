using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace multiplication_table_in_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            int result = 0;
            int num=10;
            num = Convert.ToInt32(textBox1.Text);
            for(i=1;i<=num;i++)
            {
                result = num * i;
                label2.Text = "result" + result;
            }
        }
    }
}
