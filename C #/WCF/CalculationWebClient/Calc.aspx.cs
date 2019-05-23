using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculationWebClient
{
    public partial class Calc : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSum_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient client = new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Sum(a, b);
            txtResult.Text = c.ToString();
        }

        protected void btnSub_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient client = new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Sub(a, b);
            txtResult.Text = c.ToString();

        }

        protected void btnMult_Click(object sender, EventArgs e)
        {
            ServiceReference1.CalcServiceClient client = new ServiceReference1.CalcServiceClient();
            int a, b, c;
            a = Convert.ToInt32(txtFirstno.Text);
            b = Convert.ToInt32(txtSecondNo.Text);
            c = client.Mult(a, b);
            txtResult.Text = c.ToString();

        }
    }
}