﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;
using BMS.DAL.BookServiceReference;


namespace AspWcfLayeredDemo
{
    public partial class UpdateBook : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtBookid.Text == string.Empty)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "m2", "alert('Please enter id to search')", true);
            }
            else
            {
                try
                {
                    int searchId = Convert.ToInt32(txtBookid.Text);
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
                catch(Exception ex)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('"+ex.Message+";)", true);

                }
            }
            
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Book book = new Book();
                book.ID = Convert.ToInt32(txtBookid.Text);
                book.Name = txtName.Text;
                book.Price = Convert.ToDecimal(txtPrice.Text);
                book.Description = txtDescription.Text;

                bool status = BookBLL.UpdateBookBLL(book);

                if (status)
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "m3", "alert('book details updated')", true);

                    txtBookid.Text = "";
                    txtName.Text = "";
                    txtPrice.Text = "";
                    txtDescription.Text = "";
                }

            }
            catch(Exception ex)
            {
                ScriptManager.RegisterStartupScript(this, this.GetType(), "error1", "alert('" + ex.Message + "')", true);
            }
        }
    }
}