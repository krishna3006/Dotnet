using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Studentdemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlCommand cmd;

        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = "integrated security=true;initial catalog=sqlpractice;data source=DESKTOP-AKGKCCF";
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            cmd = new SqlCommand("SELECT * FROM StudentDemo", cnSqlpractice);
            SqlDataReader dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                txtStudentId.Text = dr["studentid"].ToString();
                txtStudentname.Text = dr["StudentNAme"].ToString();
                txtMobile.Text = dr["Mobile"].ToString();
                txtEmail.Text = dr["Email"].ToString();
            }

        }
    }
}
