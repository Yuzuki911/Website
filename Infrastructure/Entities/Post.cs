using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Website.Models;

namespace Infrastructure
{
    public class Post : BaseEntity
    {
        public string Title { get; set; }
        public string Excerpt { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }

        #region Relation

        [Key]
        [Column(Order = 1)]
        [ForeignKey("User")]
        public string User_Id { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }

        #endregion
    }
}
