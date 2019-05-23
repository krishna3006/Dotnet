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
    public partial class DeleteEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteEmploy_Click(object sender, EventArgs e)
        {
            if (txtEmpno.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Enter Book ID')", true);
            }
            else
            {
                try
                {
                    int deleteEmpno = Convert.ToInt32(txtEmpno.Text);
                    string status = EmployBLL.DeleteEmployBLL(deleteEmpno);                    
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('"+status+"')", true);
                   
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error3", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}