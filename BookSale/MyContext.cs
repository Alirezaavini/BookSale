using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using BOL.Model;
using System.Text;

namespace BookSale
{
   public class MyContext:DbContext
    {

        public DbSet<Book> Books;
        public DbSet<Sale> Sales;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=APTESCO-PC2\\SQLEXPRESS2017;Initial Catalog=DBBook;Integrated Security=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Sale>()
                .HasOne(p => p.Book)
                .WithMany(b => b.Sales)
                .HasForeignKey(p => p.BookId)
                .HasConstraintName("ForeignKey_Sale_Book");
        }

    }
}
