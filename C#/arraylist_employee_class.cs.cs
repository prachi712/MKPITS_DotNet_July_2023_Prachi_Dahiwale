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

namespace Arraylist_employee_class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        ArrayList ar = new ArrayList();
        private void button1_Click(object sender, EventArgs e)
        {
            
            employee emp = new employee(Convert.ToInt32(textBox1.Text), textBox2.Text,
                Convert.ToInt32(textBox3.Text),textBox4.Text);
            ar.Add(emp);
               textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(employee emp in ar)
            {
                sb.Append("empno=" + emp.empno + "empname=" + emp.empname + "salary=" + emp.salary + "designation=" + emp.designation);
            }
            label5.Text = sb.ToString();
        }
    }
}
