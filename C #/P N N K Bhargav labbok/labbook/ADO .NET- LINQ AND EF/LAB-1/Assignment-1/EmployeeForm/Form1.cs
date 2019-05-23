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
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dreader = null;
                //The Procedure to execute
                SqlCommand cmd = new SqlCommand("GetEmployeeById", cnSqlpractice);
                cmd.CommandType = CommandType.StoredProcedure;
                //define procedure parameter
                SqlParameter prm;
                prm = new SqlParameter();
                prm.SqlDbType = SqlDbType.Int;
                prm.Direction = ParameterDirection.Input;
                prm.ParameterName = "@eno";
                cmd.Parameters.Add(prm);
                //assign parameter value
                cmd.Parameters["@eno"].Value = int.Parse(txtempno.Text);
                //execute
                dreader = cmd.ExecuteReader();
                //if employee record found
                if (dreader.Read())
                {
                    txtempname.Text = dreader["empname"].ToString();
                    txtsalary.Text = dreader["empsal"].ToString();
                    if (dreader["emptype"].ToString() == "P")
                        rdpayroll.Checked = true;
                    else
                        rdconsultant.Checked = true;
                }
                else
                {
                    btnNew_Click(btnnew, e);
                    MessageBox.Show("No such employee");
                }
                dreader.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //The Insert DML to add employee record
                SqlCommand cmd = new SqlCommand("insert into employee values(@eno, @enm, @esal, @etyp)", cnSqlpractice);
                //The Parameters
                cmd.Parameters.Add("@eno", SqlDbType.Int);
                cmd.Parameters.Add("@enm", SqlDbType.VarChar, 50);
                cmd.Parameters.Add("@esal", SqlDbType.Decimal);
                cmd.Parameters.Add("@etyp", SqlDbType.VarChar, 1);
                //Assigning Values to parameters
                cmd.Parameters["@eno"].Value = txtempno.Text;
                cmd.Parameters["@enm"].Value = txtempname.Text;
                cmd.Parameters["@esal"].Value = txtsalary.Text;
                cmd.Parameters["@etyp"].Value = rdpayroll.Checked == true ? "P" : "C";
                //Execute Insert ....
                cmd.ExecuteNonQuery();
                MessageBox.Show("Employee Details Saved");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
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
            txtempno.Focus();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlDataReader dreader = null;
                //The Procedure to execute
                SqlCommand cmd = new SqlCommand("GetEmployeeById", cnSqlpractice);
                cmd.CommandType = CommandType.StoredProcedure;
                //define procedure parameter
                SqlParameter prm;
                prm = new SqlParameter();
                prm.SqlDbType = SqlDbType.Int;
                prm.Direction = ParameterDirection.Input;
                prm.ParameterName = "@eno";
                cmd.Parameters.Add(prm);
                //assign parameter value
                cmd.Parameters["@eno"].Value = int.Parse(txtempno.Text);
                //execute
                dreader = cmd.ExecuteReader();
                //if employee record found
                if (dreader.Read())
                {
                    txtempname.Text = dreader["empname"].ToString();
                    txtsalary.Text = dreader["empsal"].ToString();
                    if (dreader["emptype"].ToString() == "P")
                    { rdpayroll.Checked = true; }
                    else
                    { rdconsultant.Checked = true; }
                    MessageBox.Show("Click on Confirm button to Delete Record");
                }
                else
                {
                    btnNew_Click(btnnew, e);
                    MessageBox.Show("No such employee record found to delete");
                }
                dreader.Close();
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void btnconfirm_Click(object sender, EventArgs e)
        {
            SqlCommand cmdInsertSp = new SqlCommand("prcEmployeeDelete", cnSqlpractice);
            cmdInsertSp.CommandType = CommandType.StoredProcedure;
            cmdInsertSp.Parameters.AddWithValue("@empno", txtempno.Text);
            cmdInsertSp.Parameters.Add(new SqlParameter("@RES", SqlDbType.Int));
            cmdInsertSp.Parameters["@RES"].Direction = ParameterDirection.Output;
            cmdInsertSp.ExecuteNonQuery();
            int res = Convert.ToInt32(cmdInsertSp.Parameters["@RES"].Value);
            if (res == 1)
            {
                foreach(Control c in Controls)
                {
                    if(c is TextBox)
                    {
                        c.Text = "";
                    }
                }
                MessageBox.Show("Record Deleted Successfully....");
            }
            else
            {
                MessageBox.Show("Record Not Found....");
            }
        }
    }
}
