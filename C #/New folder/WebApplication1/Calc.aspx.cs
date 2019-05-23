using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondno.Text);
            c = a + b;
            txtResult.Text = c.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondno.Text);
            c = a - b;
            txtResult.Text = c.ToString();

        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondno.Text);
            c = a * b;
            txtResult.Text = c.ToString();
        }

        protected void lbNames_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Names.aspx");
            Server.Transfer("Names.aspx");
        }
    }
}