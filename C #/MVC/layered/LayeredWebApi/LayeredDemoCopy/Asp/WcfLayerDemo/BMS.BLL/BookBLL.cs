﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BMS.DAL.BookServiceReference;//Added
using BMS.DAL;//Added

namespace BMS.BLL
{
    public class BookBLL
    {
        public static bool ValidateBook(Book book)     //1st
        {
            bool result = true;
            StringBuilder sb = new StringBuilder();

            if (book.ID <= 0 || book.ID == null)
            {
                result = false;
                sb.Append("ID cannot be blank or negative");
            }

            if (book.Name == string.Empty)
            {
                result = false;
                sb.Append("Book Name cannot be blank");
            }

            if (book.Description == string.Empty)
            {
                result = false;
                sb.Append("Description cannot be blank");
            }
            if (book.Price <= 0 || book.Price == null)
            {
                result = false;
                sb.Append("Price cannot be negative or zero");
            }

            if (result == false)
            {
                throw new BookException.BookException(sb.ToString());
            }
            return result;
        }
        public static List<Book> GetBooksBLL()        //2nd task
        {
            List<Book> bookllist = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                bookllist = bmsdal.GetBooksDAL();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return bookllist;

        }
        public static Book GetBookBLL(int bookid)    //3rd task
        {
            Book book = null;
            try
            {
                BookDAL bmsdal = new BookDAL();
                book = bmsdal.GetBookDAL(bookid);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return book;
        }
        public static bool AddBookBLL(Book book)     //4th task
        {
            bool bookadded = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL obj = new BookDAL();
                    bookadded = obj.AddBookDAL(book);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return bookadded;
        }
        public static bool UpdateBookBLL(Book book)     //5th task
        {
            bool bookUpdated = false;
            try
            {
                if (ValidateBook(book))
                {
                    BookDAL bmsdal = new BookDAL();
                    bookUpdated = bmsdal.UpdateBookDAL(book);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            return bookUpdated;
        }
        public static bool DeleteBookBLL(int id)       //6th task
        {
            bool bookdelete = false;

            try
            {
                if (id > 0)
                {
                    BookDAL bmsdal = new BookDAL();
                    bookdelete = bmsdal.DeleteBookDAL(id);
                }
                else
                {
                    throw new BookException.BookException("Invalid Book ID");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return bookdelete;
        }
    }
}
