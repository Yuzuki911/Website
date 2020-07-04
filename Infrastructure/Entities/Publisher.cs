using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Publisher : BaseEntity
    {
        public string Name { get; set; }

        #region Relation

        public virtual ICollection<Book> Books { get; set; }

        #endregion
    }
}
