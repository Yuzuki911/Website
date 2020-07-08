using Common.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IBookRepository : IGenericRepository<Book>
    {
        ICollection<Book> GetAllBook();

        ICollection<Book> GetCountNewBook(int countBook);

        ICollection<Book> GetCountBestSeller(int countBook);

        ICollection<Book> GetBooksByGenreId(Guid id);
    }
}
