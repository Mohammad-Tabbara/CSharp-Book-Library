using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookLibrary.Services
{
    public class BookService
    {
        private ApplicationDbContext db;

        public BookService(ApplicationDbContext dbContext)
        {
            db = dbContext;
        }
        public void CreateBook(string bookName, decimal rentPrice)
        {
            var book = new Book { BookName= bookName, RentPrice = rentPrice, CreatedAt = DateTime.Now.ToString(), UpdatedAt = DateTime.Now.ToString() };
            db.Book.Add(book);
            db.SaveChanges();
        }
    }
}