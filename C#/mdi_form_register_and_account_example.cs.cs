using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mdi_form_register_account_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void registerFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent=this;
            a.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void acoountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void accountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            registerform r = new registerform();
            r.MdiParent = this;
            r.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            accountform a = new accountform();
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToString();
        }
    }
}
