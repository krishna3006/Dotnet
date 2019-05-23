using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnected2
{
    public partial class Agent : Form
    {
        string strcon = "Integrated security=true;initial catalog=sqlpractice;" + "data source=DESKTOP-AKGKCCF";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;
        public Agent()
        {
            InitializeComponent();
        }

        private void Agent_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string sqlselect = "SELECT Agentid,Firstname,LAstname,city,SSN FROM Agent";
            cmdQuery = new SqlCommand(sqlselect, cnSqlpractice);
            SqlDataReader dr = cmdQuery.ExecuteReader();
            if (dr.Read()) ;
            {
                txtAgentid.Text = dr["Agentid"].ToString();
                txtFirstname.Text = dr["Firstname"].ToString();
                txtLastname.Text = dr["Lastname"].ToString();
                txtCity.Text = dr["City"].ToString();
                txtSSN.Text = dr["SSN"].ToString();
            }
        }

    }
}
