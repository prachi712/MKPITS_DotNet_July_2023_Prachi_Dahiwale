using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace area_of_rectangle_with_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Rectangle r = new Rectangle();
            r.width = Convert.ToInt32(textBox1.Text);

            r.height = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            r.getdata(r.width, r.height);
            sb.Append("Area of Rectangle=" + r.area);
            label3.Text = sb.ToString();
        }
    }
}
