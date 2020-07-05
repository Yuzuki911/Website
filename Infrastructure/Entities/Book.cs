using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Book : BaseEntity
    {
        public Book() : base()
        {
            if (Publish_Date == null)
            {
                Publish_Date = DateTime.Now;
            }
            IsHot = false;
            IsBestSeller = false;
        }

        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Descript { get; set; }
        public DateTime Publish_Date { get; set; }
        public int Price { get; set; }
        public string Book_Cover { get; set; }
        public string Book_BCover { get; set; }
        public string Book_Preview1 { get; set; }
        public string Book_Preview2 { get; set; }
        public Boolean IsHot { get; set; }
      
        public Boolean IsBestSeller { get; set; }
        public int Stock { get; set; }
        #region Relation
        //[Key]
        //[Key,Column(Order = 1)]
        [ForeignKey("Publisher")]
        public Guid Publisher_Id { get; set; }
        //[Required]
        public virtual Publisher Publisher { get; set; }
        public virtual ICollection<Book_Author> Book_Authors { get; set; }
        public virtual ICollection<Book_Genre> Book_Genres { get; set; }
        public virtual ICollection<OrderDetail> OrderDetails { get; set; }
        public virtual ICollection<Wishlist> Wishlists { get; set; }

        #endregion
    }
}
