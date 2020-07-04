using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Models;

namespace Infrastructure.Entities
{
    public class Wishlist
    {
        #region Relation

        [Key]
        [Column(Order = 1)]
        [ForeignKey("User")]
        public string User_Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Book")]
        public Guid Book_Id { get; set; }

        public virtual Book Book { get; set; }

        #endregion
    }
}
