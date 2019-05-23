using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlCommand cmdSelectSp;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("database connected...");
            cmdSelectSp = new SqlCommand("prcEmpSearch", cnSqlpractice);
            cmdSelectSp.CommandType = CommandType.StoredProcedure;
            cmdSelectSp.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            SqlDataReader dr = cmdSelectSp.ExecuteReader();
            if (dr.Read())
            {
                txtEmpname.Text = dr["nam"].ToString();
                txtDept.Text = dr["Dept"].ToString();
                txtDesig.Text = dr["Desig"].ToString();
                txtBasic.Text = dr["Basic"].ToString();
            }
            else
            {
                MessageBox.Show("Records not found...");
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string strCon = ConfigurationManager.
                ConnectionStrings["SqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strCon);
            cnSqlpractice.Open();
            //MessageBox.Show("database Connected...");
            SqlCommand cmdInsertSp = new SqlCommand("prcEmpInsert", cnSqlpractice);
            cmdInsertSp.CommandType = CommandType.StoredProcedure;
            cmdInsertSp.Parameters.AddWithValue("@empno", Convert.ToInt32(txtEmpno.Text));
            cmdInsertSp.Parameters.AddWithValue("@name", txtEmpno.Text);
            cmdInsertSp.Parameters.AddWithValue("@dept", txtDept.Text);
            cmdInsertSp.Parameters.AddWithValue("@Desig", txtDesig.Text);
            cmdInsertSp.Parameters.AddWithValue("@basic", Convert.ToInt32(txtBasic.Text));
            cmdInsertSp.ExecuteNonQuery();
            MessageBox.Show("record Inserted..");
        }
    }
}
