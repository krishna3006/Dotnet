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

namespace Studentdemo
{
    public partial class Insert : Form
    {        
        public Insert()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlPractice;
        SqlCommand cmd;      
        private void Insert_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["SqlPracticeconn"].ConnectionString;
            cnSqlPractice = new SqlConnection(strcon);
            cnSqlPractice.Open();
            SqlCommand cmdSelect = new SqlCommand("SELECT MAX(studentid)+1 FROM StudentDemo", cnSqlPractice);
            int id = Convert.ToInt32(cmdSelect.ExecuteScalar());
            id++;
            txtStudentId.Text = id.ToString();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["SqlPracticeconn"].ConnectionString;
            cnSqlPractice = new SqlConnection(strcon);
            cnSqlPractice.Open();
            cmd = new SqlCommand("INSERT INTO Studentdemo VALUES(@Studentid,@studentname,@mobile,@Email)", cnSqlPractice);
            cmd.Parameters.AddWithValue("@Studentname", txtStudentname.Text);
            cmd.Parameters.AddWithValue("@mobile", Convert.ToInt64(txtMobile.Text));
            cmd.Parameters.AddWithValue("@email", txtEmail.Text);
            cmd.Parameters.AddWithValue("Studentid", Convert.ToInt32(txtStudentId.Text));
            cmd.ExecuteNonQuery();
            MessageBox.Show("Inserted successfully...");
        }

    }
}

