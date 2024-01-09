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
using System.Diagnostics.Eventing.Reader;
using System.Security.Cryptography.X509Certificates;
using System.Linq.Expressions;

namespace Course_Registeration_Form_Project
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;database=course_registeration";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from tablenation order by nation_id", con);
                ds = new DataSet();
                da.Fill(ds, "tablenation");
                comboBox1.DataSource = ds.Tables["tablenation"];
                comboBox1.DisplayMember = "nation_name";
                comboBox1.ValueMember = "nation_id";


            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablestate where nation_id=@nation_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@nation_id", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "states");
                    comboBox2.DataSource = ds.Tables["states"];
                    comboBox2.DisplayMember = "state_name";
                    comboBox2.ValueMember = "state_id";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from tablecity where state_id=@state_id", con);
                    da.SelectCommand.Parameters.AddWithValue("@state_id", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();

                    da.Fill(ds, "tablecity");
                    comboBox3.DataSource = ds.Tables["tablecity"];
                    comboBox3.DisplayMember = "city_name";
                    comboBox3.ValueMember = "city_id";
                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        public enum category { student, it_professional }
        public enum gender { male, female, other }
        category cat;
        gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selecteddate = dateTimePicker1.Value;
            if (selecteddate.Date < DateTime.Today)
            {
                MessageBox.Show("please select a payment date that is on ",  MessageBoxIcon.Error);
                return;

            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("full name cant be blank");
            }
            else
            {
                if (radioButton1.Checked)
                {
                    cat = category.student;

                }
                else if (radioButton2.Checked)
                {
                    cat = category.it_professional;
                }
                MessageBox.Show("category" + cat);
                if (radioButton3.Checked)
                {
                    gen = gender.male;
                }
                else if (radioButton4.Checked)
                {
                    gen = gender.female;

                }
                
            }
        }
        public void savecorseregdetail(category c, gender g)
        {
            try
            {
                string str = "insert into tablecourseregdetail values(@categoryid,@fullname,@genderid");
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@categoryid", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@fullname", textBox1.Text);
                command.Parameters.AddWithValue("@genederid", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                con.Close();


            }



        

            
            public void clear()
            { 

                radioButton1.Checked = true;
                radioButton2.Checked = false;
                radioButton3.Checked = true;
                radioButton4.Checked = false;
                radioButton5.Checked = false;
                comboBox1.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                textBox3.Text = string.Empty;
                textBox4.Text = string.Empty;
                dateTimePicker1.Text = DateTime.Now.ToString();
            }



        }
    }
    
}


