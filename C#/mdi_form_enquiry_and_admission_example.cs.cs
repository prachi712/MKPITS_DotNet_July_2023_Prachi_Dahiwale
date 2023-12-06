using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace mdi_form_enqury_and_admission_example
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enquiryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            enquiry en = new enquiry();
            en.MdiParent = this;
            en.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.Text == "prachi" && textBox2.Text == "123")
            {
                panel1.Visible = false;
                enquiryToolStripMenuItem.Enabled = true;
                admissionToolStripMenuItem.Enabled = true;
            }
            else 
            {
                MessageBox.Show("invalid credentials");
            }
            
        }
        


        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            admission an = new admission();
            an.MdiParent = this;
            an.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            enquiry en = new enquiry();
            en.MdiParent = this;
            en.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            admission an = new admission();
            an.MdiParent = this;
            an.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void verticleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void horizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }
    }
}
