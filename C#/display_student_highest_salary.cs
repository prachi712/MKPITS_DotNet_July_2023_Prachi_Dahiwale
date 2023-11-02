using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace display_highest_fees
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        student[] stud = new student[10];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            stud[0] = new student();
            stud[1] = new student();
            stud[2] = new student();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                stud[cnt].rollno = Convert.ToInt32(textBox1.Text);
                stud[cnt].name = textBox2.Text;
                stud[cnt].date = textBox3.Text;
                stud[cnt].fees = Convert.ToInt32(textBox4.Text);
                cnt++;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    textBox4.Enabled = false;
                    button2.Enabled = true;
                    MessageBox.Show("student details of 10 accepted");

                        


                }


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("student details are:" + "\n");
            for(int i=0;i<3; i++)
            {
                sb.Append("----------------\n");
                sb.Append("student rollno:" + stud[i].rollno + "\n");
                sb.Append("student name:" + stud[i].name + "\n");
                sb.Append("student date:" + stud[i].date + "\n");
                sb.Append("student fees:" + stud[i].fees + "\n");
            }
            label4.Text = sb.ToString();
            double high = stud[0].fees;
            int foundat = 0;
            for(int i=0;i<3;i++)
            {
                
                    if (high < stud[i].fees)
                    {
                        high = stud[i].fees;
                        foundat =i;
                    }

                
            }
            StringBuilder sb1 = new StringBuilder();
            sb1.Append("stud with high fees:\n");
            sb1.Append("stud rollno" + stud[foundat].rollno + "\n");
            sb1.Append("stud name=" + stud[foundat].name + "\n");
            sb1.Append("stud date=" + stud[foundat].date + "\n");
            sb1.Append("stud fees=" + stud[foundat].fees + "\n");
            label6.Text = sb1.ToString();
        }
    }
}
