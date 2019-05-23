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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter adapter;
        DataSet dsEmp;
        SqlCommandBuilder cmdBuilder;
        int i, count;

        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            adapter = new SqlDataAdapter("SELECT * FROM Emp", cnSqlpractice);
            cmdBuilder = new SqlCommandBuilder(adapter);
            dsEmp = new DataSet();
            adapter.Fill(dsEmp, "EmpDummy");
            i = 0;
            count = dsEmp.Tables["EmpDummy"].Rows.Count;
            ShowEmploy();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            i = 0;
            ShowEmploy();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i++;
            if(i==count)
            {
                i = 0;
            }
            ShowEmploy();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            i--;
            if(i<0)
            {
                i=count-1;
            }
            ShowEmploy();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = count - 1;
            ShowEmploy();
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }               
            }
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            string strAutogen = "SELECT MAX(Empno)+1 FROM Emp";
            SqlDataAdapter adAutoGen = new SqlDataAdapter(strAutogen, cnSqlpractice);
            DataSet ds = new DataSet();
            adAutoGen.Fill(ds, "EmpAuto");
            txtEmpno.Text = ds.Tables["empAuto"].Rows[0][0].ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow dr = dsEmp.Tables["EmpDummy"].NewRow();
            dr["empno"] = txtEmpno.Text;
            dr["name"] = txtEmpname.Text;
            dr["dept"]=txtDept.Text;
            dr["desig"] = txtDesig.Text;
            dr["basic"] = txtBasic.Text;
            dsEmp.Tables["EmpDummy"].Rows.Add(dr);
        }

        private void btnFinalChanges_Click(object sender, EventArgs e)
        {
            adapter.Update(dsEmp, "EmpDummy");
            MessageBox.Show("cnanges are permanent");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataColumn[] keyColumns = new DataColumn[1];
            keyColumns[0] = dsEmp.Tables["EmpDummy"].Columns["empno"];
            dsEmp.Tables["empDummy"].PrimaryKey = keyColumns;
            int empno = Convert.ToInt32(txtEmpno.Text);
            DataRow dr = dsEmp.Tables["EmpDummy"].Rows.Find(empno);
            dr.Delete();
            MessageBox.Show("click on final changes button...");
        }
        private void ShowEmploy()
        {
            txtEmpno.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Empno"].ToString();
            txtEmpname.Text = dsEmp.Tables["EmpDummy"].Rows[i]["nam"].ToString();
            txtDept.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Dept"].ToString();
            txtDesig.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Desig"].ToString();
            txtBasic.Text = dsEmp.Tables["EmpDummy"].Rows[i]["Basic"].ToString();
        }
    }
}
