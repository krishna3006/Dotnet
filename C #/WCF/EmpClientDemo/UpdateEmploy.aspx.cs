using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;

namespace EmpClientDemo
{
    public partial class UpdateEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            EmpServiceClient client = new EmpServiceClient();
            Emp emp = new Emp();
            emp.Empno = Convert.ToInt32(txtEmployno.Text);
            emp.name = txtName.Text;
            emp.Dept = txtDepartment.Text;
            emp.Desig = txtDesignation.Text;
            emp.Basic = Convert.ToInt32(txtBasic.Text);
            bool result = client.UpdateEmp(emp);
            if(result==true)
            {
                Response.Write("Data Updated Successfully");
            }
        }
        protected void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        protected void txtEmployno_TextChanged(object sender, EventArgs e)
        {
            Emp emp = null;
            EmpServiceClient client = new EmpServiceClient();
            emp = client.SearchEmp(Convert.ToInt32(txtEmployno.Text));
            if (emp != null)
            {
                txtName.Text = emp.name;
                txtDepartment.Text = emp.Dept;
                txtDesignation.Text = emp.Desig;
                txtBasic.Text = emp.Basic.ToString();
            }
        }
    }
}