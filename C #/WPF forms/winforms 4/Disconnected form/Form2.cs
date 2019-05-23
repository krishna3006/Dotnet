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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        DataSet dsEmp;
        int i, count;

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            string strSelect = "SELECT * FROM EMP WHERE Empno=@empno";
            adapter = new SqlDataAdapter(strSelect, cnSqlpractice);
            adapter.SelectCommand.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            dsEmp = new DataSet();
            adapter.Fill(dsEmp, "EmpDummy");
            count = dsEmp.Tables["EmpDummy"].Rows.Count;
            if(count==1)
            {
                txtEmpname.Text = dsEmp.Tables["EmpDummy"].Rows[i]["nam"].ToString();
                txtDept.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Dept"].ToString();
                txtDesig.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Desig"].ToString();
                txtBasic.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Basic"].ToString();
            }
            else
            {
                MessageBox.Show("records not found...");
            }
        }
    }
}
