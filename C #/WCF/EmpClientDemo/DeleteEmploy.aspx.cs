using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EmpClientDemo.ServiceReference1;


namespace EmpClientDemo
{
    public partial class DeleteEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtEmployNo_TextChanged(object sender, EventArgs e)
        {
            Emp emp = null;
            EmpServiceClient client = new EmpServiceClient();
            emp = client.SearchEmp(Convert.ToInt32(txtEmployNo.Text));
            if (emp != null)
            {
                txtName.Text = emp.name;
                txtDepartment.Text = emp.Dept;
                txtDesignation.Text = emp.Desig;
                txtBasic.Text = emp.Basic.ToString();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            {
                EmpServiceClient client = new EmpServiceClient();
                client.DeleteEmp(Convert.ToInt32(txtEmployNo.Text));
                Response.Write("Deleted Successfully..");
                Response.Redirect("ShowEmploy.aspx");
            }
        }
    }
}