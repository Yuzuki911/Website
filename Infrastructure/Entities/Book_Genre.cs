using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Book_Genre
    {
        #region Relation

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Genre")]
        public Guid Genre_Id { get; set; }

        public virtual Genre Genre { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Book")]
        public Guid Book_Id { get; set; }

        public virtual Book Book { get; set; }

        #endregion
    }
}
