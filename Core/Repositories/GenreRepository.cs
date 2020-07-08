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
    public class GenreRepository : GenericRepository<Genre>, IGenreRepository
    {
        public GenreRepository(BookStoreDbContext dbContext) : base(dbContext)
        {

        }

        public Guid GetGenreIdByGenreName(string nameGenre)
        {
            return _dbContext.Genres.Where(t => t.Name.Contains(nameGenre)).Select(t => t.Id).FirstOrDefault() ;
        }
    }
}
