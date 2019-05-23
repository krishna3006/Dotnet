using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlPractice_Emp
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            Customer obj = new Customer();
            obj.CustID = Convert.ToInt32(txtCustID.Text);
            obj.CustName = txtCustName.Text;
            obj.Premium = Convert.ToInt32(txtPremium.Text);
            obj.Installment = Convert.ToInt32(txtInsta.Text);
            obj.Comments = txtComm.Text;            
            ENT.Customers.Add(obj);
            ENT.SaveChanges();
            MessageBox.Show("Record Inserted Successfully..");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            var max = ENT.Customers.Max(p => p.CustID) + 1;
            txtCustID.Text = max.ToString();
        }
    }
}
