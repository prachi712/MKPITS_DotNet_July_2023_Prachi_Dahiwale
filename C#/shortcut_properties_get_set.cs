using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shortcut_properties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            person2 p1 = new person2();
            p1.Name = textBox1.Text;
            p1.Age = Convert.ToInt32(textBox2.Text);
            p1.Address = textBox3.Text;
            StringBuilder sb = new StringBuilder();
            sb.Append("name:" + p1.Name + "\n");
            sb.Append("age:" + p1.Age + "\n");
            sb.Append("address:" + p1.Address + "\n");
            label4.Text = sb.ToString();
        }
    }
}
