using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agent
{
    public partial class Calc : System.Web.UI.UserControl
    {
        public string Label1Firstnumber
        {
            get
            {
                return lblFirstno.Text;
            }
            set
            {
                lblFirstno.Text = value;
            }
        }
        public string Label2Secondnumber
        {
            get
            {
                return lblSecondno.Text;
            }
            set
            {
                lblSecondno.Text = value;
            }
        }
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
    }
}