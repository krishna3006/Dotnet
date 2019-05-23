using EmpClientDemo.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpClientDemo
{
    public partial class InsertEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            EmpServiceClient client = new EmpServiceClient();
            int empno = client.AutoGenerateEmpno();
            txtEmployNo.Text = empno.ToString();

        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            EmpServiceClient client = new EmpServiceClient();
            Emp emp = new Emp();         
            emp.Empno =Convert.ToInt32(txtEmployNo.Text);
            emp.name = txtName.Text;
            emp.Dept = txtDepartment.Text;
            emp.Desig = txtDesignation.Text;
            emp.Basic = Convert.ToInt32(txtBasic.Text);
            bool result = client.InsertEmp(emp);
            if(result==true)
            {
                Response.Write("REcord inserted successfully....");
            }
        }
    }
}