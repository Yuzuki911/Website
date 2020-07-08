using Common.Services;
using Core.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;

namespace Core.Services
{
    public class BookService : EntityService<Book>, IBookService
    {
        private readonly IBookRepository _repository;

        public BookService(IBookRepository repository) : base(repository)
        {
            _repository = repository;
        }
        public ICollection<Book> GetAllBook()
        {
            return _repository.GetAllBook();
        }
        public ICollection<Book> GetCountNewBook(int countBook)
        {
            return _repository.GetCountNewBook(countBook);
        }
        public ICollection<Book> GetCountBestSeller(int countBook)
        {
            return _repository.GetCountBestSeller(countBook);
        }

        public ICollection<Book> GetBooksByGenreId(Guid id)
        {
            return _repository.GetBooksByGenreId(id);
        }
    }
}
