using Common.Services;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Core.Services
{
    public interface IBookService : IEntityService<Book>
    {
        ICollection<Book> GetAllBook();
        ICollection<Book> GetCountNewBook(int countBook);

        ICollection<Book> GetCountBestSeller(int countBook);

        ICollection<Book> GetBooksByGenreId(Guid id);
    }
}
