using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Configuration;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentdemo
{
    public partial class Search : Form
    {
        SqlConnection cnSqlPractice;
        SqlCommand cmd;
        public Search()
        {
            InitializeComponent();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            string strcon = "integrated security=true;initial catalog=sqlpractice;data source=DESKTOP-AKGKCCF";
            cnSqlPractice = new SqlConnection(strcon);
            cnSqlPractice.Open();
            cmd = new SqlCommand("SELECT * FROM StudentDemo Where StudentID=@Studentid", cnSqlPractice);
            cmd.Parameters.AddWithValue("@Studentid", Convert.ToInt32(txtStudentId.Text));
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                txtStudentname.Text = dr["Studentname"].ToString();
                txtMobile.Text = dr["Mobile"].ToString();
                txtEmail.Text = dr["Email"].ToString();
            }
            else
            {
                txtStudentname.Clear();
                txtMobile.Clear();
                txtEmail.Clear();
                MessageBox.Show("No records found");
            }

        }
    }
}
