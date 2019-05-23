using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EMSWebLayeredDemo
{
    public partial class EMS : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkUpdtaeEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateEmploy.aspx");
        }

        protected void lnkAddEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmploy.aspx");
        }

        protected void lnkSearchEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchEmploy.aspx");
        }

        protected void lnkDeleteEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("DeleteEmploy.aspx");
        }

        protected void lnkShowEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewEmploy.aspx");
        }
    }
}