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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            sqlpracticeEntities ENT = new sqlpracticeEntities();
            EMp obj = new EMp();
            obj.Empno = Convert.ToInt32(txtNumber.Text);
            obj.nam = txtName.Text;
            obj.dept = txtDept.Text;
            obj.desig = txtDesig.Text;
            obj.basic = Convert.ToInt64(txtBasic.Text);
            ENT.EMps.Add(obj);
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

        private void Form2_Load(object sender, EventArgs e)
        {
            sqlpracticeEntities ENT = new sqlpracticeEntities();            
            var max = ENT.EMps.Max(p => p.Empno) + 1;
            txtNumber.Text = max.ToString();
        }
    }
}
