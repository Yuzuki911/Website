using Common.Services;
using Core.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
namespace Core.Services
{
    public class GenreService : EntityService<Genre>, IGenreService
    {
        private readonly IGenreRepository _repository;

        public GenreService(IGenreRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public Guid GetGenreIdByGenreName(string nameGenre)
        {
            return _repository.GetGenreIdByGenreName(nameGenre);
        }
    }
}
