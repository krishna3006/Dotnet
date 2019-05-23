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
    public partial class Delete_Book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if(txtBookID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('Enter Book ID')", true);
            }
            else
            {
                try
                {
                    int deleteId = Convert.ToInt32(txtBookID.Text);
                    bool status = BookBLL.DeleteBookBLL(deleteId);
                    if (status)
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('Book Details Deleted')", true);
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m6", "alert('Unable to delete book')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error3", "alert('" + ex.Message +"')", true);
                }
            }
        }
    }
}