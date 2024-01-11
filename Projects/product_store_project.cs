using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace fendyl_productstore_project
{
    public partial class Form1 : Form
    {
        public enum Nationality { Indian,NRI}
        Nationality nat;
        string strcon = "server=.\\sqlexpress;integrated security=true;database=product_store";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getcategory();
            getproduct();
            getprice();
            nat = Nationality.Indian;

        }
        public void getcategory()
        {
            con = new SqlConnection(strcon);
            da = new SqlDataAdapter("select * from tableproductcategory", con);
            ds = new DataSet();
            da.Fill(ds, "tpc");
            comboBox1.DataSource = ds.Tables["tpc"];
            comboBox1.DisplayMember = "product_type_name";
            comboBox1.ValueMember = "product_category_id";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("enter only numbers");

            }
        } 

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getproduct();
            if(comboBox1.Text != "System.Data.DataRowView")
            {
                string catname = comboBox1.Text;
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproductgstdetails where gst_detail_name=@gdn", con);
                da.SelectCommand.Parameters.AddWithValue("@gdn", catname);
                ds = new DataSet();

            }
        }
        public void  getproduct()
        {

            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView") 
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproduct where product_category_id=@pci", con);
                da.SelectCommand.Parameters.AddWithValue("@pci", comboBox1.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp");
                comboBox2.DataSource = ds.Tables["tp"];
                comboBox2.DisplayMember = "product_name";
                comboBox2.ValueMember = "product_id";
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getprice();
        }
        public void getprice()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tableproduct where product_id=@pid", con);
                da.SelectCommand.Parameters.AddWithValue("@pid", comboBox2.SelectedValue);
                ds = new DataSet();
                da.Fill(ds, "tp1");
                foreach (DataRow dr in ds.Tables["tp1"].Rows)
                {
                    textBox9.Text = dr["product_price"].ToString();
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                nat = Nationality.Indian;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton2.Checked)
            {
                nat = Nationality.NRI;
            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            
            }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            if (textBox11.Text != "")
            {
                double price = Convert.ToDouble(textBox9.Text);
                double quantity = Convert.ToDouble(textBox10.Text);
                double totalamount = price * quantity;
                textBox11.Text = totalamount.ToString();

            }
        }
    }
}
 
