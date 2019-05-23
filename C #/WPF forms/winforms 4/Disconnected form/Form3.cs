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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        DataSet dsAgent;
        int i, count;
        private void Form3_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM Agent", cnSqlpractice);
            dsAgent = new DataSet();
            adapter.Fill(dsAgent, "AgentDummy");
            i = 0;
            count = dsAgent.Tables["AgentDummy"].Rows.Count;
            ShowAgent();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            ShowAgent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if (i == count)
            {
                i = 0;
            }
            ShowAgent();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            i--;
            if (i < 0)
            {
                i = count - 1;
            }
            ShowAgent();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = count - 1;
            ShowAgent();
        }


        private void ShowAgent()
        {
            txtAgentid.Text = dsAgent.Tables["AgentDummy"].Rows[i]["Agentid"].ToString();
            txtFirstname.Text = dsAgent.Tables["AgentDummy"].Rows[i]["firstname"].ToString();
            txtLastname.Text = dsAgent.Tables["AgentDummy"].Rows[i]["lastname"].ToString();
            txtCity.Text = dsAgent.Tables["AgentDummy"].Rows[i]["city"].ToString();
            txtSSN.Text = dsAgent.Tables["AgentDummy"].Rows[i]["SSN"].ToString();
        }
    }
}