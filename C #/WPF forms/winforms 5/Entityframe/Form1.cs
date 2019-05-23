using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entityframe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sqlpracticeEntities ent = new sqlpracticeEntities();
            var max = (ent.EMps.OrderByDescending(p => p.Empno).FirstOrDefault().Empno) + 1;
            //max++;
            txtEmpno.Text = max.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ent = new sqlpracticeEntities();
            EMp emp = ent.EMps.Find(Convert.ToInt32(txtEmpno.Text));
            if (emp != null)
            {
                txtEmployname.Text = emp.nam.ToString();
                txtDept.Text = emp.dept.ToString();
                txtDesig.Text = emp.desig.ToString();
                txtBasic.Text = emp.basic.ToString();
           }

        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ent = new sqlpracticeEntities();
            EMp emp = new EMp();
            emp.Empno = Convert.ToInt32(txtEmpno.Text);
            emp.nam = txtEmployname.Text;
            emp.dept = txtDept.Text;
            emp.desig = txtDesig.Text;
            emp.basic = Convert.ToInt32(txtBasic.Text);
            ent.EMps.Add(emp);
            ent.SaveChanges();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ent = new sqlpracticeEntities();
           EMp emp = ent.EMps.Find(Convert.ToInt32(txtEmpno.Text));
            emp.nam = txtEmployname.Text;
            emp.dept = txtDept.Text;
           emp.desig = txtDesig.Text;
            emp.basic = Convert.ToInt32(txtBasic.Text);
            ent.SaveChanges();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            sqlpracticeEntities ent = new sqlpracticeEntities();
            EMp emp = ent.EMps.Find(Convert.ToInt32(txtEmpno.Text));
            ent.EMps.Remove(emp);
            ent.SaveChanges();
        }
        
    }
}


