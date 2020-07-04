using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Author : BaseEntity
    {
        public string Name { get; set; }

        #region Relation

        public virtual ICollection<Book_Author> Book_Authors { get; set; }

        #endregion
    }
}
