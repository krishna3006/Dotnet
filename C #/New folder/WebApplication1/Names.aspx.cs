using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Names1 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            if (PreviousPage != null)
            {
                Response.Write("Request came from" + PreviousPage.ToString());
            }
            if (!IsPostBack)
            {
                ddlNames.Items.Add("Bhargav");
                ddlNames.Items.Add("Krishna");
                ddlNames.Items.Add("Arun");
                ddlNames.Items.Add("Siva");
            }
        }

        protected void ddlNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            Response.Write("Selected Name" + ddlNames.Text);
        }
    }
}