using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agent
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string fname, lname, fulName;
            fname = Request.QueryString["fname"].ToString();
            lname = Request.QueryString["lname"].ToString();
            fulName = fname + "" + lname;
            Response.Write("fulName" + fulName);
                
        }

        protected void btnRedirect_Click(object sender, EventArgs e)
        {
            Response.Redirect("Nameshow.aspx?fname=" + txtFirstname.Text + "&lname" + txtSecondname.Text);
        }
    }
}