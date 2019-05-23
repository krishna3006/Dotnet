using EmpClientDemo.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpClientDemo
{
    public partial class SearchEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Emp emp = null;
            EmpServiceClient client = new EmpServiceClient();
            emp = client.SearchEmp(Convert.ToInt32(txtEmployno.Text));
            if(emp!=null)
            {
                txtName.Text = emp.name;
                txtDepartment.Text = emp.Dept;
                txtDesignation.Text = emp.Desig;
                txtSalary.Text = emp.Basic.ToString();
            }
        }
    }
}