using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Genre : BaseEntity
    {
        public string Name { get; set; }
        #region Relation

        public virtual ICollection<Book_Genre> Book_Genres { get; set; }

        #endregion
    }
}
