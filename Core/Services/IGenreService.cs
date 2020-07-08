﻿using Common.Services;
using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IGenreService : IEntityService<Genre>
    {
        Guid GetGenreIdByGenreName(string nameGenre);
    }
}
