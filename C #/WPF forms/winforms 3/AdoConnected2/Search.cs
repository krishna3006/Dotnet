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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        string strcon = "integrated security=true;initial catalog=sqlpractice;" + "data source=DESKTOP-AKGKCCF";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strSearch="SELECT * FROM Agent where Agentid=@Agentid";
            cmdQuery = new SqlCommand(strSearch, cnSqlpractice);
            cmdQuery.Parameters.AddWithValue("@Agentid", Convert.ToInt32(txtAgentid.Text));
            SqlDataReader dr = cmdQuery.ExecuteReader();
            if (dr.Read())
            {
                txtFirstname.Text = dr["Firstname"].ToString();
                txtLastname.Text = dr["Lastname"].ToString();
                txtCity.Text = dr["city"].ToString();
                txtSSN.Text = dr["SSN"].ToString();
            }
            else
            {
                txtFirstname.Clear();
                txtLastname.Clear();
                txtCity.Clear();
                txtSSN.Clear();
            }
            
        }

        private void Search_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strUpd = "UPDATE Agent SET Id=@Id,Firstname=@Firstname," + "lastname=@lastname,city=@city,SSN=@SSN WHERE Agentid=@Agentid";
            SqlCommand cmdUpdate = new SqlCommand(strUpd, cnSqlpractice);
            cmdUpdate.Parameters.AddWithValue("@Firstname", txtFirstname.Text);
            cmdUpdate.Parameters.AddWithValue("@Lastname", txtLastname.Text);
            cmdUpdate.Parameters.AddWithValue("@City", txtCity.Text);
            cmdUpdate.Parameters.AddWithValue("@SSN", txtSSN.Text);
            cmdUpdate.ExecuteNonQuery();
            MessageBox.Show("record Updated...");
        }
        
    }
}
