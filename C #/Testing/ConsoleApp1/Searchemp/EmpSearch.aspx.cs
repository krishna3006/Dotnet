﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace Searchemp
{
    public partial class EmpSearch : System.Web.UI.Page
    {
        SqlConnection connection;
        SqlCommand cmd;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeconn"].ConnectionString;
            connection = new SqlConnection(strcon);
            connection.Open();
            cmd = new SqlCommand("prcEmpOut", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@empno",
                Convert.ToInt32(txtEmployno.Text));
            cmd.Parameters.Add(new SqlParameter("@Nam", SqlDbType.VarChar, 30));
            cmd.Parameters["@Nam"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Dept", SqlDbType.VarChar, 30));
            cmd.Parameters["@Dept"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Desig", SqlDbType.VarChar, 30));
            cmd.Parameters["@Desig"].Direction = ParameterDirection.Output;
            cmd.Parameters.Add(new SqlParameter("@Basic", SqlDbType.Int));
            cmd.Parameters["@Basic"].Direction = ParameterDirection.Output;
            cmd.ExecuteNonQuery();
            txtName.Text = cmd.Parameters["@Nam"].Value.ToString();
            txtDept.Text = cmd.Parameters["@Dept"].Value.ToString();
            txtDesig.Text = cmd.Parameters["@Desig"].Value.ToString();
            txtBasic.Text = cmd.Parameters["@Basic"].Value.ToString();

        }
    }
}