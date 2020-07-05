using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Models;

namespace Infrastructure.Entities
{
    public class Order : BaseEntity
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string TotalPrice { get; set; }
        #region Relation

        [ForeignKey("User")]
        public string User_Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<OrderDetail> OrderDetails { get; set; }

        #endregion
    }
}
