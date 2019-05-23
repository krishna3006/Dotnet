using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studentdemo
{
    public partial class Gridview : Form
    {
        public Gridview()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlPractice;
        SqlCommand cmd;
        private void Gridview_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["SqlPracticeconn"].ConnectionString;
            cnSqlPractice = new SqlConnection(strcon);
            cnSqlPractice.Open();
            cmd = new SqlCommand("SELECT * FROM Studentdemo", cnSqlPractice);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);
            dgStudent.DataSource = dt;
        }
    }
}
