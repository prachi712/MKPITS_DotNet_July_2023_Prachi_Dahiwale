﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace datetimepicker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Text);
            label2.Text = dateTimePicker1.Text;
            label3.Text = dateTimePicker1.Value.ToLongDateString();
            label4.Text = dateTimePicker1.Value.ToShortDateString();
            label5.Text = dateTimePicker1.Value.Date.Year.ToString();
        }
    }
}
