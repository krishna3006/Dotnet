using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Configuration;//add
using System.Data;//add
using System.Data.SqlClient;//add

namespace BMS.WcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "BookService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select BookService.svc or BookService.svc.cs at the Solution Explorer and start debugging.
    public class BookService : IBookService
    {
        static string strcon = ConfigurationManager.ConnectionStrings["bookconn"].ConnectionString;
        SqlConnection conn = new SqlConnection(strcon);
        SqlCommand cmd;
        SqlDataReader dr;
        public List<Book> ShowBook()       //1st task
        {
            List<Book> bookList = null;
            try
            {
                cmd = new SqlCommand("usp_ShowBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    bookList = new List<Book>();
                    while (dr.Read())
                    {
                        Book b = new Book();
                        b.ID = dr.GetInt32(0);
                        b.Name = dr.GetString(1).ToString();
                        b.Price = dr.GetDecimal(2);
                        b.Description = dr.GetString(3).ToString();
                        bookList.Add(b);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return bookList;
        }
        public Book SearchBook(int id)      //2nd task
        {
            Book book = null;
            try
            {
                cmd = new SqlCommand("usp_SearchBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                conn.Open();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dr.Read();
                    book = new Book();
                    book.ID = dr.GetInt32(0);
                    book.Name = dr.GetString(1);
                    book.Price = dr.GetDecimal(2);
                    book.Description = dr.GetString(3);
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                dr.Close();
                conn.Close();
            }
            return book;
        }
        public bool AddBook(Book book)   //3rd task
        {
            bool bookAdded = false;

            try
            {
                cmd = new SqlCommand("usp_InsertBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                conn.Open();
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                    bookAdded = true;
            }
            catch (Exception )
            {
                throw ;
            }
            finally
            {
                conn.Close();
            }

            return bookAdded;
        }
        public bool UpdateBook(Book book)     //4th task
        {
            bool bookUpdated = false;
            try
            {               
                cmd = new SqlCommand("usp_UpdateBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", book.ID);
                cmd.Parameters.AddWithValue("@name", book.Name);
                cmd.Parameters.AddWithValue("@price", book.Price);
                cmd.Parameters.AddWithValue("@desc", book.Description);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    bookUpdated = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return bookUpdated;
        }
        public bool DeleteBook(int BookID)       //5th task
        {
            bool bookdeleted = false;
            try
            {
                cmd = new SqlCommand("usp_DeleteBook", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", BookID);
                conn.Open();
                int result = cmd.ExecuteNonQuery();
                if (result > 0)
                    bookdeleted = true;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                conn.Close();
            }
            return bookdeleted;
        }

    }
}
