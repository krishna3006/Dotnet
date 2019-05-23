using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class MasterDB : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAgent_Click(object sender, EventArgs e)
        {
            Response.Redirect("AgentPage.aspx");
        }

        protected void lnkPolicy_Click(object sender, EventArgs e)
        {
            Response.Redirect("PolicyPage.aspx");
        }

        protected void lnkEmp_Click(object sender, EventArgs e)
        {
            Response.Redirect("EmpPage.aspx");
        }
    }
}