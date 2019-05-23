using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoConnected1
{
    public partial class Form1 : Form
    {
        string strcon = "Integrated security=true;initial catalog=sqlpractice;" + "data source=DESKTOP-AKGKCCF";
        SqlConnection cnSqlpractice;
        SqlCommand cmdQuery;
        public Form1()
        {
            InitializeComponent();
        }
      
        private void Form1_Load_1(object sender, EventArgs e)
        {
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            string sqlselect = "SELECT empno,nam,dept,desig,basic FROM Emp";
            cmdQuery = new SqlCommand(sqlselect, cnSqlpractice);
            SqlDataReader dr = cmdQuery.ExecuteReader();
            if (dr.Read()) ;
            {
                txtEmpno.Text = dr["Empo"].ToString();
                txtEmpname.Text = dr["Nam"].ToString();
                txtDept.Text = dr["Dept"].ToString();
                txtDesig.Text = dr["Desig"].ToString();
                txtBasic.Text = dr["Basic"].ToString();
            }
        }
    }
}
