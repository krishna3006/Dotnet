using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;
using BMS.DAL.BookServiceReference;

namespace AspWcfLayeredDemo
{
    public partial class DeleteBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnDeleteBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('please enter id')", true);
            }
            else
            {
                try
                {
                    int deleteid = Convert.ToInt32(txtBookID.Text);
                    bool status = BookBLL.DeleteBookBLL(deleteid);
                    if (status)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('book details deleted'", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m6", "alert('unable to delete book')", true);
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