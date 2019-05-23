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
    public partial class UpdateEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
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

        protected void btnUpdateEmploy_Click(object sender, EventArgs e)
        {
            
        }

        protected void btnUpdateEmploy_Click1(object sender, EventArgs e)
        {
            try
            {
                Employ employ = new Employ();
                employ.Empno = Convert.ToInt32(txtEmpno.Text);
                employ.Name = txtName.Text;
                employ.Dept = txtDept.Text;
                employ.Desig = txtDesig.Text;
                employ.Basic = Convert.ToInt32(txtBasic.Text);
                bool status = EmployBLL.UpdateEmployBLL(employ);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('Employ Details Updated')", true);
                    txtEmpno.Text = "";
                    txtName.Text = "";
                    txtDept.Text = "";
                    txtDesig.Text = "";
                    txtBasic.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
            }
        }
    }
}