using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace windows_form_example_mdi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void forwardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fn = openFileDialog1.FileName;
                MessageBox.Show(fn);
                if(fn.EndsWith("rtf"))
                {
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                }
                else
                {
                    MessageBox.Show("cannot open this file");
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string fn = saveFileDialog1.FileName;
                MessageBox.Show(fn);
                if(fn.EndsWith("rtf"))
                {
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                    MessageBox.Show("file saved successfully");
                }
                else
                {
                    MessageBox.Show("can not save file of this format");
                }
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }
    }
}
