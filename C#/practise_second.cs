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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=.\\SQLEXPRESS;integrated security=true;database=mksample");
        DataSet ds = new DataSet();
        SqlDataAdapter da;
        SqlCommandBuilder cb = null;
        private void button1_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from student", con);
            cb = new SqlCommandBuilder(da);
            da.Fill(ds, "studname");
            dataGridView1.DataSource = ds.Tables["studname"];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                da.Update(ds.Tables["studname"]);
                MessageBox.Show("record updated");
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
