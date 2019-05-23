﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ApplicationUsers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection cnSqlpractice;
        SqlDataAdapter da;
        DataSet ds;

        private void btnstate_Click(object sender, EventArgs e)
        {
            //Iterate through Rows of DataTable and display RowStates .....
            foreach (DataRow drow in ds.Tables["appusers"].Rows)
            {
                if (drow.RowState == DataRowState.Deleted)
                {
                    MessageBox.Show(drow["username", DataRowVersion.Original].ToString() +
                    " deleted ");
                }
                else
                    MessageBox.Show(drow["username"].ToString() + " " +
                   drow.RowState.ToString());
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                //Save Changes to Database
                da.Update(ds.Tables["appusers"]);
                MessageBox.Show("Changes Saved");
            }
            catch (SqlException sqlex)
            {
                MessageBox.Show(sqlex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
            cnSqlpractice = new SqlConnection(strcon);
            cnSqlpractice.Open();
            ds = new DataSet();
            //select - For Data Retrieval
            da = new SqlDataAdapter("select * from applicationusers", cnSqlpractice);
            //So that we should be able to save changes back to database....
            SqlCommandBuilder bld = new SqlCommandBuilder(da);
            da.Fill(ds, "appusers");
            grdUsers.DataSource = ds.Tables["appusers"];
        }

        private void btnCancelChanges_Click(object sender, EventArgs e)
        {
            ds.Tables["appusers"].RejectChanges();
        }
    }
}