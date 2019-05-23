using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;//add
using BMS.DAL.BookServiceReference;//ad
using BMS.DAL;//add

namespace BMSWebApp
{
    public partial class DeleteBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btndelete_Click(object sender, EventArgs e)
        {
            if (txtId.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Please enter the id ')", true);
            }
            else
            {
                try
                {
                    int deleteId = Convert.ToInt32(txtId.Text);
                    bool status = BookBLL.DeleteBookBLL(deleteId);
                    if (status)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('Book Details deleted ')", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m6", "alert('Unable to Delete book ')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error3", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}