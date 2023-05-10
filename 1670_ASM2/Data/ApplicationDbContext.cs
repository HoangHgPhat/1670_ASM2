using _1670_ASM2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace _1670_ASM2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Book_Author>().HasKey(ba => new
            {
                ba.BookId,
                ba.AuthorId
            });

            builder.Entity<Book_Author>().HasOne(b => b.Book).WithMany(ba => ba.Books_Authors).HasForeignKey(b => b.BookId);
            builder.Entity<Book_Author>().HasOne(b => b.Author).WithMany(ba => ba.Books_Authors).HasForeignKey(b => b.AuthorId);
            base.OnModelCreating(builder); 
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Author> Books_Authors { get; set; }
        public DbSet<Publisher> Publishers { get; set; }
    }
}