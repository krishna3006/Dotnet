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
    public partial class AddEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAddEmploy_Click(object sender, EventArgs e)
        {
            try
            {
                Employ employ = new Employ();
                employ.Empno = Convert.ToInt32(txtEmpno.Text);
                employ.Name = txtName.Text;
                employ.Dept = txtDept.Text;
                employ.Desig = txtDesig.Text;
                employ.Basic = Convert.ToInt32(txtBasic.Text);
                bool status = EmployBLL.AddEmployBLL(employ);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m1", "alert('Employ Details Added')", true);
                    txtEmpno.Text = "";
                    txtName.Text = "";
                    txtDept.Text = "";
                    txtDesig.Text = "";
                    txtBasic.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "error5", "alert('" + ex.Message + "')", true);
            }
        }
    }
}