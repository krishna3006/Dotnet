using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;//add

namespace BMS.DAL
{
    public class BookDAL
    {
        BookServiceClient client = new BookServiceClient();
        public Book GetBookDAL(int id)     //2nd task
        {
            Book book = null;
            try
            {
                book = client.SearchBook(id);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return book;
        }
        public List<Book> GetBooksDAL()    //1st task
        {
            List<Book> blist = null;
            try
            {
                blist = client.ShowBook().ToList();
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return blist;
        }
        public bool AddBookDAL(Book book)      //3rd task
        {
            bool bookAdded = false;
            try
            {
                bookAdded = client.AddBook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookAdded;
        }
        public bool UpdateBookDAL(Book book)      //4th task
        {
            bool updateBook = false;
            try
            {
                updateBook = client.UpdateBook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return updateBook;
        }
        public bool DeleteBookDAL(int id)      //5th task
        {
            bool bookDeleted = false;
            try
            {
                bookDeleted = client.DeleteBook(id);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookDeleted;
        }

    }

}
