using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Agent
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MultiView1_ActiveViewChanged(object sender, EventArgs e)
        {

        }

        protected void Menu1_MenuItemClick(object sender, MenuEventArgs e)
        {
            MultiView1.ActiveViewIndex = Convert.ToInt32(e.Item.Value);
        }
    }
}