using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
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


    }
}
