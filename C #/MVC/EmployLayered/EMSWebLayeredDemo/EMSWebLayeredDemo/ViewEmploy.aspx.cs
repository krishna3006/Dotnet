using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EMS.BLL;
using EMS.DAL.EmployServiceReference;

namespace EMSWebLayeredDemo
{
    public partial class ViewEmploy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Employ> elist = EmployBLL.GetEmploysBLL();
                GridView1.DataSource = elist.ToList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message;
            }
        }
    }
}