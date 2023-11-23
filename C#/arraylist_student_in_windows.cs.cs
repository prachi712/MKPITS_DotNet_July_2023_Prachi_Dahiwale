using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace arraylist_windows_student_name
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            ar.Add(textBox1.Text);
            textBox1.Clear();
            textBox1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("capacity" + ar.Capacity);
            MessageBox.Show("count" + ar.Count);
            StringBuilder sb = new StringBuilder();
            foreach(object obj in ar)
            {
                sb.Append("name=" + obj.ToString());
            }
            label2.Text = ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
