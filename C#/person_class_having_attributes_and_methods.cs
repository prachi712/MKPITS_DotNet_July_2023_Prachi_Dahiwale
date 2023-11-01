using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace person_clss_n_attribute_and_method
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person1 p1 = new person1();
            p1.name = textBox1.Text;
            p1.age = Convert.ToInt32(textBox2.Text);
            p1.address = textBox3.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + p1.name + "\n");
            sb.Append("age:" + p1.age + "\n");
            sb.Append("address:" + p1.address + "\n");
            label4.Text = sb.ToString();
        }
    }
}
