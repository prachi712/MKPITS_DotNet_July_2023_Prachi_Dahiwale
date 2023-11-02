using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarybook_available_for_borrow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        librartbbok[] book = new librartbbok[3];
        int cnt = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            book[0] = new librartbbok();
            book[1] = new librartbbok();
            book[2] = new librartbbok();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                book[cnt].title = textBox1.Text;
                book[cnt].author = textBox2.Text;
                if(checkBox1.Checked)
                {
                    book[cnt].isavailable = true;
                }
            }
            cnt++;
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            if(cnt==3)
            {
                button1.Enabled = false;
                textBox1.Enabled = false;
                textBox2.Enabled = false;
                button1.Enabled = true;
                MessageBox.Show("details are 3 books");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("available book are:" + "\n");
            for(int i=0;i<3;i++)
            {
                if (book[i].isavailable==true)
                {
                    sb.Append("title:" + book[i].title +"\n");
                    sb.Append("author:" + book[i].author + "\n");
                }
            }
            label3.Text = sb.ToString();
        }
    }
}

