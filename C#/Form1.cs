using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ado_dotnet_login_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=mksample";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "select count(*)from users where username=@username and password=@password";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@username", SqlDbType.VarChar ,20).Value = textBox1.Text;
                command.Parameters.Add("@password", SqlDbType.VarChar, 20).Value = textBox2.Text;
                con.Open();
                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if (cnt > 0)
                    label3.Text = "login successfull";
                else
                    label3.Text = "invalid credentials,try again";
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }
    }
}
