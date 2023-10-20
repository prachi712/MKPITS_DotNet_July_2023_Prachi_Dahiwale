using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_area_of_rectangle_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int length, breadth, area;
            length = Convert.ToInt32(textBox1.Text);
            breadth = Convert.ToInt32(textBox2.Text);
            area = length * breadth;
            label3.Text = "result" + area;
        }
    }
}
