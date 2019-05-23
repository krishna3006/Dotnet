﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BMS.BLL;//add
using BMS.DAL.BookServiceReference;//add

namespace BMSWebApp
{
    public partial class ViewBooks : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                List<Book> blist = BookBLL.GetBooksBLL();
                GridView1.DataSource = blist.ToList();
                GridView1.DataBind();
            }
            catch (Exception ex)
            {

                lblError.Text = ex.Message; ;
            }
        }
    }
}