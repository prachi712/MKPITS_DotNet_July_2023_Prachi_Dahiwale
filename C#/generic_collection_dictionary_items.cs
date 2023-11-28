using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generic_collections_dictionary_in_orders_item
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Dictionary<int, orders> ordercollection = new Dictionary<int, orders>();
        orders ord = null;
        private void button1_Click(object sender, EventArgs e)
        {
            ord = new orders(Convert.ToInt32(textBox1.Text), textBox2.Text, Convert.ToInt32(textBox3.Text), Convert.ToInt32(textBox4.Text));
         ordercollection.Add(Convert.ToInt32(textBox1.Text), ord);
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Focus();
            MessageBox.Show("customer object added to dictionary");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            foreach(KeyValuePair<int,orders>kvp in orders)
            {
                int amount = kvp.Value.rate * kvp.Value.quantity;
                total = total + amount;
                sb.Append("order id=" + kvp.Key + "itemname=" + kvp.Value.itemname + "rate" + kvp.Value.rate
                    + "quantity=" + kvp.Value.quantity + "amount" + "\n");
            }
            label5.Text = sb.ToString();
        }
    }
}
