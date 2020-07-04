using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Entities
{
    public class Book : BaseEntity
    {

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
        public int Publisher_Id { get; set; }
        public Boolean IsBestSeller { get; set; }

    }
}
