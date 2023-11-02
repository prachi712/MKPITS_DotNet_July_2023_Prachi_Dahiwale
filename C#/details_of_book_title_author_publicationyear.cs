using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_class_with_windows_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        book[] bk = new book[3];
        int cnt = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bk[0] = new book();
            bk[1] = new book();
            bk[2] = new book();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if(cnt<3)
            {
                bk[cnt].title = textBox1.Text;
                bk[cnt].author = textBox2.Text;
                bk[cnt].publicationyear = Convert.ToInt32(textBox3.Text);
                cnt++;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();

                textBox1.Focus();
                if(cnt==3)
                {
                    button1.Enabled = false;
                    textBox1.Enabled = false;
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    button2.Enabled = false;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("book details are:" + "\n");
            for(int i=0;i<3;i++)
            {
                sb.Append("-------------\n");
                sb.Append("title:" + bk[i].title + "\n");
                sb.Append("author:" + bk[i].author + "\n");
                sb.Append("publicationyear:" + bk[i].publicationyear + "\n");
                sb.Append("------------------\n");
                label4.Text = bk.ToString();
            }
        }
    }
}
