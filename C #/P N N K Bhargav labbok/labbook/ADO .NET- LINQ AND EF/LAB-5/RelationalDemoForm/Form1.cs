using System;
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

namespace RelationalDemoForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        string strcon = ConfigurationManager.ConnectionStrings["sqlpracticeConn"].ConnectionString;
        SqlDataAdapter dacat, daprod;
        DataSet ds_cat_pro;
        private void Form1_Load(object sender, EventArgs e)
        {
            //FORM LEVEL MEMBERS
            con = new SqlConnection(strcon);                        dacat = new SqlDataAdapter("select * from category", con);
            daprod = new SqlDataAdapter("select * from product", con);
            con.Open();
            ds_cat_pro = new DataSet();
            dacat.Fill(ds_cat_pro, "cat");
            daprod.Fill(ds_cat_pro, "pro");
            con.Close();
            //Setting Default Constraint
            ds_cat_pro.Tables["pro"].Columns["categoryid"].DefaultValue = 1;

            //CREATING RELATION BETWEEN THE TWO DATA TABLES
            DataRelation dre1 = new DataRelation("catpro_relation",ds_cat_pro.Tables["cat"].Columns["CategoryId"],ds_cat_pro.Tables["pro"].Columns["CategoryId"]);
            ds_cat_pro.Relations.Add(dre1);
            ds_cat_pro.Relations["catpro_relation"].ChildKeyConstraint.DeleteRule= Rule.None;
            ds_cat_pro.Relations["catpro_relation"].ChildKeyConstraint.UpdateRule= Rule.None;

            //DIFFERENT CONSTRAINT RULE OPTIONS:
            //NONE WILL NOT ALLOW DELETING MASTER RECORD
            //CASCADE WILL DELETE MASTER AS WELL AS CHILD RECORDS
            //SETDEFAULT: WILL ALLOW DELETION OF MASTER RECORD AND SET THE VALUE IN CHILD WHICH IS DEFAULT
            //SETNULL: WILL SET VALUE OF COLUMN TO NULL IN CHILD TABLE AND DELETE RECORD FROM MASTER TABLE

            grdCategories.DataSource = ds_cat_pro.Tables["cat"];
            grdProducts.DataSource = ds_cat_pro.Tables["cat"];
            grdProducts.DataMember = "catpro_relation";
        }
    }
}
