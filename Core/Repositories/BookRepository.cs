using Common.Repositories;
using Infrastructure.DataContext;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    class BookRepository : GenericRepository<Book> ,IBookRepository
    {
        public BookRepository(BookStoreDbContext dbContext) : base(dbContext)
        {

        }
        public ICollection<Book> GetAllBook()
        {
            return _dbContext.Books.Where(t => t.IsDeleted == false && t.Stock > 0).OrderBy(t => t.CreatedDate).ToList();
        }
        public ICollection<Book> GetCountNewBook(int countBook)
        {
            return _dbContext.Books.Where(t => t.IsDeleted == false && t.Stock > 0).OrderByDescending(t => t.CreatedDate).Take(countBook).ToList();
        }

        public ICollection<Book> GetCountBestSeller(int countBook)
        {
            return _dbContext.Books.Where(t => t.IsDeleted == false && t.Stock > 0 && t.IsBestSeller == true).OrderBy(t => t.CreatedDate).Take(countBook).ToList();
        }

        public ICollection<Book> GetBooksByGenreId(Guid id)
        {
            var listGenreBook = _dbContext.Book_Genres.
                                        Where(t => t.Genre_Id == id).Select(t => t.Book_Id).ToList();
            return _dbContext.Books.Where(t => listGenreBook.Contains(t.Id)).OrderBy(t => t.CreatedDate).ToList();
        }
    }
}
