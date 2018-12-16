using System;
using BOL.Model;
using BookSale;
using Microsoft.EntityFrameworkCore;

namespace DAL
{
    public class Class1
    {
        Book book = new Book();
       public void insert()
        {
            // book.Id = 1;
            book.AuthorName = "ali";
            book.Name = "te";
            book.Price = 1000;
            MyContext ctx = new MyContext();
            ctx.Add(book);
            ctx.SaveChanges();
            Sale s = new Sale();
            s.BookId = 2;
            s.count = 2;
            s.sum = 200;
            ctx.Add(s);
            ctx.SaveChanges();

        }
    }
}
