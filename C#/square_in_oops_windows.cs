using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace square_of_number_windows_in_oops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        squarecs sq=new squarecs();
        private void button1_Click(object sender, EventArgs e)
        {
            int num=(Convert.ToInt32(textBox1.Text));
            sq.sqr(num);
            label2.Text = "square" + sq.area;
        }
    }
}
