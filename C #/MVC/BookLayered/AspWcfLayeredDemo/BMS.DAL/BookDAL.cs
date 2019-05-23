using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;

namespace BMS.DAL
{
    public class BookDAL
    {
        BookServiceClient client = new BookServiceClient();
        public bool DeleteBookDAL(int id)
        {
            bool bookDeleted = false;
            try
            {
                bookDeleted = client.Deletebook(id);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookDeleted;
        }
        public bool UpdateBookDAL(Book book)
        {
            bool UpdatedBook = false;
            try
            {
                UpdatedBook = client.Updatebook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return UpdatedBook;
        }
        public bool AddBookDAL(Book book)
        {
            bool bookAdded = false;
            try
            {
                bookAdded = client.Addbook(book);
            }
            catch (Exception ex)
            {

                throw new BookException.BookException(ex.Message);
            }
            return bookAdded;
        }
        public Book GetBookDAL(int id)
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
        public List<Book> GetBooksDAL()
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
    }
}
