using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            SqlCommand cmdMax;            
            cmdMax = new SqlCommand("prcEmployeeauto", cnSqlpractice);
            cmdMax.CommandType = CommandType.StoredProcedure;
            int cid = 0;
            cid = Convert.ToInt32(cmdMax.ExecuteScalar());
            txtempno.Text = cid.ToString();
        }
       
        private void btnnew_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            rdpayroll.Checked = false;
            rdconsultant.Checked = false;
            Form1_Load(btnnew, e);
            txtempno.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmdInsertSp = new SqlCommand("prcEmployeeInsert", cnSqlpractice);
                cmdInsertSp.CommandType = CommandType.StoredProcedure;
                cmdInsertSp.Parameters.AddWithValue("@empno", txtempno.Text);
                cmdInsertSp.Parameters.AddWithValue("@empname", txtempname.Text);
                cmdInsertSp.Parameters.AddWithValue("@empsal", txtsalary.Text);
                cmdInsertSp.Parameters.AddWithValue("@emptype", rdpayroll.Checked == true ? "P" : "C");
                cmdInsertSp.ExecuteNonQuery();
                MessageBox.Show("Record added Successfully....");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }
    }
}
