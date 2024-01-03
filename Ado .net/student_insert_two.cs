using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ado_dotnet__student
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studentclass s = new studentclass();
            string g = null;

            if (radioButton1.Checked)
            {
                g = "male";
            }
            else if (radioButton2.Checked)
            {
                g = "female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "music";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                    h = h + " " + "reading";
                else

                    h = "reading";
            }
            string result = s.Insertstudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            //cleartext();
        }
    }
}
