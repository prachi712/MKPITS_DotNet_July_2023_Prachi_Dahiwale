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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void hScrollBar2_Scroll(object sender, ScrollEventArgs e)
        {
            richTextBox1.Width = hScrollBar1.Value;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            richTextBox1.Height = vScrollBar1.Value;
        }
    }
}
