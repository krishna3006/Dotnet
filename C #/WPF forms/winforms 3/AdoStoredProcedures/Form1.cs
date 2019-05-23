using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoStoredProcedures
{
    public partial class Form1 : Form
    {
        public Form1()
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
            cmdSelectSp = new SqlCommand("prcEmpShow", cnSqlPractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            //DataTable dt = new DataTable();
            //dt.Load(dr);
            //object dgEmp = null;
            //dgEmp.DataSource = dt;
            
            if(dr.Read())
            {
                txtEmpno.Text = dr["empno"].ToString();
                txtEmpname.Text = dr["nam"].ToString();
                txtDept.Text = dr["Dept"].ToString();
                txtDesig.Text = dr["Desig"].ToString();
                txtBasic.Text = dr["Basic"].ToString();
            }
        }
    }
}
