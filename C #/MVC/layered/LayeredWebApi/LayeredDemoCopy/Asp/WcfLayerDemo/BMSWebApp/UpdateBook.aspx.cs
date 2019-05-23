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
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        protected void btnsearch_Click(object sender, EventArgs e)
        {
            if (txtBookid.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter the id to search')", true);
            }
            else
            {
                try
                {

                    int searchID = Convert.ToInt32(txtBookid.Text);
                    Book book = BookBLL.GetBookBLL(searchID);
                    if (book != null)
                    {
                        txtname.Text = book.Name;
                        txtPrice.Text = book.Price.ToString();
                        txtDescriptiom.Text = book.Description;
                    }
                    else
                    {
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "m4", "alert('Book not Available')", true);
                    }
                }
                catch (Exception ex)
                {

                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('"+ex.Message+"')", true);
                }
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.ID = Convert.ToInt32(txtBookid.Text);
                book.Name = txtname.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDescriptiom.Text;
                bool status = BookBLL.UpdateBookBLL(book);
                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('Book Details Updated')", true);
                    txtBookid.Text = "";
                    txtname.Text = "";
                    txtDescriptiom.Text = "";
                    txtPrice.Text = "";
                }
            }
            catch (Exception ex)
            {

                ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
            }
        }
    }
}