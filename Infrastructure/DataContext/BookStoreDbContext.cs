using Infrastructure.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Website.Models;

namespace Infrastructure.DataContext
{
    public class BookStoreDbContext : IdentityDbContext<ApplicationUser>
    {
        public BookStoreDbContext() : base("BookStoreDbContext", throwIfV1Schema: false)
        {

        }

        public BookStoreDbContext(string connectionString) : base(connectionString)
        {

        }

        public static BookStoreDbContext Create()
        {
            return new BookStoreDbContext();
        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Book_Author> book_Authors { get; set; }
        public DbSet<Book_Genre> Book_Genres { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Entities.Publisher> Publishers { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
    }
}
