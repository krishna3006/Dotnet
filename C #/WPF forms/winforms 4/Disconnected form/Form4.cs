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

namespace Disconnected_form
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        DataSet dsAgent;
        int i, count;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            string strSelect = "SELECT * FROM AGENT WHERE Agentid=@Agentid";
            adapter = new SqlDataAdapter(strSelect, cnSqlpractice);
            adapter.SelectCommand.Parameters.AddWithValue("@Agentid", Convert.ToInt32(txtAgentid.Text));
            dsAgent = new DataSet();
            adapter.Fill(dsAgent, "AgentDummy");
            count = dsAgent.Tables["AgentDummy"].Rows.Count;
            if (count == 1)
            {
                txtFirstname.Text = dsAgent.Tables["AgentDummy"].Rows[i]["firstname"].ToString();
                txtLastname.Text = dsAgent.Tables["AgentDummy"].Rows[i]["lastname"].ToString();
                txtCity.Text = dsAgent.Tables["AgentDummy"].Rows[i]["city"].ToString();
                txtSSN.Text = dsAgent.Tables["AgentDummy"].Rows[i]["SSN"].ToString();
            }
            else
            {
                MessageBox.Show("records not found...");
            }
        }
    }
}
