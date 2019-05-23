using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmpClientDemo
{
    public partial class EmployCrud : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkShowEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShowEmploy.aspx");
        }

        protected void lnkSearchEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchEmploy.aspx");

        }

        protected void lnkAddEmploy_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddEmploy.aspx");

        }
    }
}