using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class OrderDetail
    {
        public int Quantity { get; set; }
        public int Price { get; set; }

        public double SubPrice { get; set; }

        #region Relation

        [Key]
        [Column(Order = 1)]
        [ForeignKey("Order")]
        public Guid Order_Id { get; set; }

        public virtual Order Order { get; set; }

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Book")]
        public Guid Book_Id { get; set; }

        public virtual Book Book { get; set; }

        #endregion Relation
    }
}
