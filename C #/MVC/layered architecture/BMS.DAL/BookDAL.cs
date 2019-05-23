﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;

namespace BMS.DAL
{
    public class BookDAL
    {
        BookServiceClient client=new BookServiceClient();

        public bool DeleteBookDAL(int id)
        {
            bool deletedBook = false;
            try
            {
                deletedBook = client.DeleteBook(id);
            }
            catch(Exception ex)
            {
                throw new BookException.BookException(ex.Message);
            }
            return deletedBook;
        }

        public bool UpdateBookDAL(Book book)
        {
            bool updatedBook = false;
            try
            {
                updatedBook = client.UpdateBook(book);
            }
            catch(Exception ex)
            {
                throw new BookException.BookException(ex.Message);
            }
            return updatedBook;
        }

        public bool AddBookDAL(Book book)
        {
            bool bookAdded = false;
            try
            {
                bookAdded = client.AddBook(book);
            }
            catch(Exception ex)
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
         public List<Book>GetBooksDAL()
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
