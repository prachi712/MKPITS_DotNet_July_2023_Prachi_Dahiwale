using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace registration_form_calculate_age
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string age = dateTimePicker1.Text;
            MessageBox.Show("DOB" + age);
            int yr = dateTimePicker1.Value.Year;
            MessageBox.Show("DOB year" + yr);
            int cyr = DateTime.Now.Year;
            MessageBox.Show("current year" + cyr);
            int diff = cyr - Convert.ToInt32(yr);
            MessageBox.Show("your age is:" + diff);
        }
    }
}
