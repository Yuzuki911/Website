using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Comment : BaseEntity
    {
        public string Email { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        #region Relation

        [Key]
        [Column(Order = 2)]
        [ForeignKey("Post")]
        public Guid Post_Id { get; set; }

        public virtual Post Post { get; set; }

        #endregion
    }
}
