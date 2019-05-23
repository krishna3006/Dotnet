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
    public partial class SearchBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearchBook_Click(object sender, EventArgs e)
        {
            if (txtBookID.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter id to search')", true);
            }
            else
            {
                try
                {
                    int searchId = Convert.ToInt32(txtBookID.Text);
                    Book book = BookBLL.GetBookBLL(searchId);
                    if (book != null)
                    {
                        txtName.Text = book.Name;
                        txtPrice.Text = book.Price.ToString();
                        txtDescription.Text = book.Description;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Book not available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
                }
            }
        }
    }
}