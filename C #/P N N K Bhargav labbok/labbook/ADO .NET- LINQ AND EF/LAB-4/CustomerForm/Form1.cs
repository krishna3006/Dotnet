using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace CustomerForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter da;
        DataSet ds;

        private void btnshow_Click(object sender, EventArgs e)
        {
           ds.Tables["cust"].DefaultView.RowFilter = "City like '" + txtcity.Text + "'";
        }       
        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            ds = new DataSet();
            //select - For Data Retrieval
            da = new SqlDataAdapter("select * from customer", strcon);
            da.Fill(ds, "cust");
            grdCustomers.DataSource = ds.Tables["cust"];
        }

        private void cmbcolumnlist_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ds.Tables["cust"].DefaultView.Sort = cmbcolumnlist.Text;
        }
    }
}
