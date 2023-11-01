using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student_details
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.name = textBox1.Text;
            s.rollno = Convert.ToInt32(textBox2.Text);
            s.subjectmarks[0] = Convert.ToInt32(textBox3.Text);
            s.subjectmarks[1] = Convert.ToInt32(textBox4.Text);
            s.subjectmarks[2] = Convert.ToInt32(textBox5.Text);

            
                
                

            StringBuilder sb = new StringBuilder();
            s.getdata(s.name, s.rollno, s.subjectmarks);
                
            sb.Append("name:" + s.name + "\n");
            sb.Append("rollno:" + s.rollno + "\n");
            sb.Append("subjectmarks:" + s.subjectmarks + "\n");
            sb.Append("total:" + s.total + "\n");
            sb.Append("average:" + s.avg + "\n");

            label5.Text = sb.ToString();


        }
    }
}
