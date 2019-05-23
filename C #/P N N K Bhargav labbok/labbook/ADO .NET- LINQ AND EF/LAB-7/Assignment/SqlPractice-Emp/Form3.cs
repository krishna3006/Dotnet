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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            Customer n = ENT.Customers.Find(Convert.ToInt32(txtCustID.Text));
            if (n != null)
            {
                txtCustName.Text = n.CustName.ToString();
                txtPremium.Text = n.Premium.ToString();
                txtInsta.Text = n.Installment.ToString();
                txtComm.Text =n.Comments.ToString();
            }
            else
            {
                MessageBox.Show("Record not Found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            Customer n = ENT.Customers.Find(Convert.ToInt32(txtCustID.Text));
            ENT.Customers.Remove(n);
            ENT.SaveChanges();
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
            MessageBox.Show("Record Deleted..");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            Customer obj = ENT.Customers.Find(Convert.ToInt32(txtCustID.Text));
            obj.CustID = Convert.ToInt32(txtCustID.Text);
            obj.CustName = txtCustName.Text;
            obj.Premium = Convert.ToInt32(txtPremium.Text);
            obj.Installment = Convert.ToInt32(txtInsta.Text);
            obj.Comments = txtComm.Text;
            ENT.SaveChanges();
            MessageBox.Show("Changes recorded");
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    c.Text = "";
                }
            }
        }
    }
}
