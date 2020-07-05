namespace Infrastructure.Migrations
{
    using Infrastructure.DataContext;
    using Infrastructure.Entities;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Website.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Infrastructure.DataContext.BookStoreDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataContext.BookStoreDbContext context)
        {
            AddGenre(context);
            AddPublisher(context);
            AddAuthor(context);
            AddRole(context);
            AddUserAdmin(context);
        }
        private void AddGenre(BookStoreDbContext context)
        {
            if (!context.Genres.Any())
            {
                context.Genres.Add(new Genre()
                {
                    Name = "Biographic",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Adventure",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Children",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Cook",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Business",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "History",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Romance",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Fiction/Fantasy",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Mystery",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Science",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Self-Improvement",
                });
                context.Genres.Add(new Genre()
                {
                    Name = "Fantasy",
                });
                context.SaveChanges();
            }
        }
        private void AddPublisher(BookStoreDbContext context)
        {
            if (!context.Publishers.Any())
            {
                context.Publishers.Add(new Publisher()
                {
                    Name = "NXB Kim Đồng",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "NXB Trẻ",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "Thái Hà Books",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "Nhã Nam",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "Alpha Books",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "Đông A Book",
                });
                context.Publishers.Add(new Publisher()
                {
                    Name = "Phương Nam Book",
                });
                context.SaveChanges();
            }
        }
        private void AddAuthor(BookStoreDbContext context)
        {
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Linda Coggin",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Chloe Benjamin",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Cheston Knapp",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Kevin Young",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Ahmed Bouanani",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Yoko Tawada",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Paulo Coelho",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Ahmed Saadawi",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Jose Revueltas",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Ian Buruma",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Nico Walker",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Samuel Park",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Olivia Laing",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Thomas Clerc",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Marina Benjamin",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Melissa Broder",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Tatjana Soli",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Lisa Brennan",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Brian Phillips",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Sam Graham",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Gunnhild Øyehaug",
                });
            }
            if (!context.Authors.Any())
            {
                context.Authors.Add(new Author()
                {
                    Name = "Rupert Carter",
                });
            }
            context.SaveChanges();
        }
        private void AddRole(BookStoreDbContext context)
        {
            if (!context.Roles.Any(t => t.Name == "Admin" && t.Name == "User"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var roleAdmin = new IdentityRole { Name = "Admin" };
                var roleUse = new IdentityRole { Name = "User" };

                manager.Create(roleAdmin);
                manager.Create(roleUse);

                context.SaveChanges();
            }
        }
        private void AddUserAdmin(BookStoreDbContext context)
        {
            if (!context.Users.Any(t => t.UserName == "Admin"))
            {
                var store = new UserStore<ApplicationUser>(context);
                var manager = new UserManager<ApplicationUser>(store);
                var user = new ApplicationUser
                {
                    UserName = "Admin",
                    Email = "admin@gmail.com",
                    FullName = "Administrator",
                    CreatedDate = DateTime.Now,
                    PhoneNumber = "19001001"
                };

                manager.Create(user, "123456");
                manager.AddToRole(user.Id, "Admin");
                manager.AddToRole(user.Id, "User");
                context.SaveChanges();
            }
        }
        //private void AddNguoiDung(BookStoreDbContext context)
        //{
        //    if (!context.Users.Any(t => t.UserName == "User"))
        //    {
        //        var store = new UserStore<ApplicationUser>(context);
        //        var manager = new UserManager<ApplicationUser>(store);
        //        var user = new ApplicationUser
        //        {
        //            UserName = "nguoidung@gmail.com",
        //            Email = "nguoidung@gmail.com",
        //            FullName = "Người dùng",
        //            CreatedDate = DateTime.Now,
        //            PhoneNumber = "19001001"
        //        };

        //        manager.Create(user, "123456");
        //        manager.AddToRole(user.Id, "User");

        //        context.SaveChanges();
        //    }
        //}
    }
}
