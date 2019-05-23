using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace AdoStoredProcedures
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlPractice;
        SqlCommand cmdSelectSp;

        private void Form1_Load(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlPractice = new SqlConnection(strCon);
            cnSqlPractice.Open();
            MessageBox.Show("database connected...");
            cmdSelectSp = new SqlCommand("prcAgentShow", cnSqlPractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            if (dr.Read())
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
