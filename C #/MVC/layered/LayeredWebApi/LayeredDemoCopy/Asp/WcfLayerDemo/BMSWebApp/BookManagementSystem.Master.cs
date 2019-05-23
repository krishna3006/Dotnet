using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BMSWebApp
{
    public partial class BookManagementSystem : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddBook.aspx");
        }

        protected void lnkUpdate_Click(object sender, EventArgs e)
        {
            Response.Redirect("UpdateBook.aspx");
        }

       
       
        protected void lnkView_Click(object sender, EventArgs e)
        {
            Response.Redirect("ViewBooks.aspx");
        }

        protected void lnkDel_Click1(object sender, EventArgs e)
        {
            Response.Redirect("DeleteBook.aspx");
        }

        protected void lnkSearch_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchBook.aspx");
        }
    }
}