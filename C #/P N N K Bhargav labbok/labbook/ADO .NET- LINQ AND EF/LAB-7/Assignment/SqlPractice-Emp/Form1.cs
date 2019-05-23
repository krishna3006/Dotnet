using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace SqlPractice_Emp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            EMp n = ENT.EMps.Find(Convert.ToInt32(txtNumber.Text));
            if (n != null)
            {
                txtName.Text = n.nam.ToString();
                txtDesig.Text = n.desig.ToString();
                txtDept.Text = n.dept.ToString();
                txtBasic.Text = Convert.ToInt64(n.basic).ToString();
            }
            else
            {
                MessageBox.Show("Record not Found");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();
            EMp j = ENT.EMps.Find(Convert.ToInt32(txtNumber.Text));            
            ENT.EMps.Remove(j);
            ENT.SaveChanges();
            foreach(Control c in this.Controls)
            {
                if(c is TextBox)
                {
                    c.Text = "";
                }
            }
            MessageBox.Show("Record Deleted..");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();            
            EMp obj = ENT.EMps.Find(Convert.ToInt32(txtNumber.Text));
            obj.Empno = Convert.ToInt32(txtNumber.Text);
            obj.nam = txtName.Text;
            obj.dept = txtDept.Text;
            obj.desig = txtDesig.Text;
            obj.basic = Convert.ToInt64(txtBasic.Text);           
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
