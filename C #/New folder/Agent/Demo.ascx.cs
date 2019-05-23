using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agent
{
    public partial class Demo : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkGoogle_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.google.com");
        }

        protected void lnkYahoo_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://www.Yahoo.com");
        }

        protected void lnkFacebook_Click(object sender, EventArgs e)
        {
            Response.Redirect("http://facebook.com");
        }
    }
}