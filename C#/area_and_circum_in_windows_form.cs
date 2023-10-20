using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_and_circumference_in_windows__form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int radius;
            float area, circ;
            radius = Convert.ToInt32(textBox1.Text);
            area = 3.14f * radius * radius;
            label2.Text = "area" + area;
            circ = 2 * 3.14f * radius;
            label3.Text = "circ" + circ;
        }
    }
}
