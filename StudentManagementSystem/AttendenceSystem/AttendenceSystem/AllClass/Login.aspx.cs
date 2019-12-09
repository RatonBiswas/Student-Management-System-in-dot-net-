using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;

namespace AttendenceSystem.AllClass
{
    public partial class Login : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["AdminConnectionString"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            conn.Open();
            string check = "select count(*) from Admin where Username='" + username.Text + "'";
            SqlCommand com = new SqlCommand(check, conn);
            int temp = Convert.ToInt32(com.ExecuteScalar().ToString());
            if (temp == 1)
            {
                String checkpassword = "select Password from Admin where Username='" + username.Text + "'";
                SqlCommand passcom = new SqlCommand(checkpassword, conn);
                String password = passcom.ExecuteScalar().ToString().Replace(" ", "");
                if (password == tpassword.Text)
                {
                    Response.Redirect("~/AllClass/Teacher.aspx");
                }
                else
                {
                    Response.Write("password is invalid");
                }
            }
            else
            {
                Response.Write("Username is invalid");
            }
            conn.Close();
        }
    }
}