using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;

namespace EMSWebLayeredDemo
{
    public partial class SearchEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchEmploy_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter Empno to search')", true);
            }
            else
            {
                try
                {
                    int searchEmpno = Convert.ToInt32(txtEmpno.Text);
                    Employ employ = EmployBLL.GetEmployBLL(searchEmpno);
                    if (employ != null)
                    {
                        txtName.Text = employ.Name;
                        txtDept.Text = employ.Dept;
                        txtDesig.Text = employ.Desig;
                        txtBasic.Text = employ.Basic.ToString();
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Employ not available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}