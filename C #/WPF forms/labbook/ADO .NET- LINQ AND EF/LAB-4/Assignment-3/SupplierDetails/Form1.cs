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

namespace SupplierDetails
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

        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            ds = new DataSet();
            //select - For Data Retrieval
            da = new SqlDataAdapter("select * from Supplier", strcon);
            //So that we should be able to save changes back to database....
            SqlCommandBuilder bld = new SqlCommandBuilder(da);
            da.Fill(ds, "supp");
            grdSupplier.DataSource = ds.Tables["supp"];
        }

        private void btnshow_Click(object sender, EventArgs e)
        {
            ds.Tables["supp"].DefaultView.RowFilter = "City like '" + txtcity.Text + "'";
        }

        private void cmbcolumnlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            ds.Tables["supp"].DefaultView.Sort = cmbcolumnlist.Text;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //Save Changes to Database
                da.Update(ds.Tables["supp"]);
                MessageBox.Show("Changes Saved");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            ds.Tables["supp"].RejectChanges();
        }
    }
}
