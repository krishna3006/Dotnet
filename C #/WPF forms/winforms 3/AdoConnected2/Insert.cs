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
    public partial class Insert : Form
    {
        public Insert()
        {
            InitializeComponent();
        }
        string strcon = "integrated security=true;initial catalog=sqlpractice;" + "data source=DESKTOP-AKGKCCF";
        SqlConnection cnSqlpractice;
        SqlCommand cmdInsert;

        private void btnInsert_Click(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strIns = "INSERT INTO Agent VALUES(@Agentid,@Firstname,@Lastname,@City,@SSN)";
            cmdInsert = new SqlCommand(strIns, cnSqlpractice);
            cmdInsert.Parameters.AddWithValue("@AgentID", Convert.ToInt32(txtAgentid.Text));
            cmdInsert.Parameters.AddWithValue("@Firstname",txtFirstname.Text);
            cmdInsert.Parameters.AddWithValue("@Lastname", txtLastname.Text);
            cmdInsert.Parameters.AddWithValue("@City",txtCity.Text);
            cmdInsert.Parameters.AddWithValue("@SSN", txtSSN.Text);
            cmdInsert.ExecuteNonQuery();
            MessageBox.Show("Record inserted");

        }

        private void Insert_Load(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string strMax = "SELECT MAX(Agentid) FROM Agent";
            SqlCommand cmdSelect = new SqlCommand(strMax, cnSqlpractice);
            int Agentid = Convert.ToInt32(cmdSelect.ExecuteScalar());
            Agentid++;
            txtAgentid.Text = Agentid.ToString();
            cnSqlpractice.Close();

        }
    }
}
