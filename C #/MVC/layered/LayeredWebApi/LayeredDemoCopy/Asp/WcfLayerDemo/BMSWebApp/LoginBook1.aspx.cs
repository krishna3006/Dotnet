using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;//add
using System.Data;//add
using System.Data.SqlClient;//add

namespace BMSWebApp
{
    public partial class LoginBook1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        static string strcon = ConfigurationManager.ConnectionStrings["bookconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd;
        //SqlDataReader dr;

        

        protected void Button1_Click1(object sender, EventArgs e)
        {
            cmd = new SqlCommand("PrcUserAuthenticate", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", txtUsername.Text.ToString());
            cmd.Parameters.AddWithValue("@passWord", txtPassWord.Text.ToString());
            conn.Open();
            int usercount = (Int32)cmd.ExecuteScalar();

            if (usercount == 1)
            {
                Response.Redirect("ViewBooks.aspx");
            }
            else
            {
                conn.Close();

            }
        }
    }
}