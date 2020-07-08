using Common.Repositories;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface IGenreRepository : IGenericRepository<Genre>
    {
        Guid GetGenreIdByGenreName(string nameGenre);

    }
}
