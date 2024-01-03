using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ado_dotnet__student
{
    internal class studentclass
    {
        string strcon = "server=.\\SQLEXPRESS;integrated security=true;database=mksample;";
        public string Insertstudent(int rno,string studentname,string gender,string hobby,string city,string dob)
        {
            using (SqlConnection con=new SqlConnection(strcon))
            {
                con.Open();
                string str = "insert into students values(@rno,@studentname,@gender,@hobby,@city,@dob)";
                using (SqlCommand command=new SqlCommand(str,con))
                {
                    command.Parameters.AddWithValue("@rno", rno);
                    command.Parameters.AddWithValue("@studentname", studentname);
                    command.Parameters.AddWithValue("@gender", gender);
                    command.Parameters.AddWithValue("@hobby", hobby);
                    command.Parameters.AddWithValue("@city", city);
                    command.Parameters.AddWithValue("@dob", dob);
                    command.ExecuteNonQuery();
                    con.Close();
                    return "record saved successfully";
                }
            }

        }
    }
}
