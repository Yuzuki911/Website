using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Website.ViewModel
{
    public class BookViewModel : BaseEntityViewModel
    {
        public BookViewModel() : base()
        {
            if (Publish_Date == null)
            {
                Publish_Date = DateTime.Now;
            }
            IsHot = false;
            IsBestSeller = false;
        }
        [DisplayName("Tên Sách")]
        public string Title { get; set; }
        [DisplayName("Mô Tả")]
        public string Excerpt { get; set; }
        [DisplayName("Mô Tả Chi Tiết")]
        public string Descript { get; set; }
        [DisplayName("Ngày Ra Mắt")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:yyyy-MM-dd}")]
        public DateTime Publish_Date { get; set; }
        [DisplayName("Giá")]
        public int Price { get; set; }
        public string Book_Cover { get; set; }
        public string Book_BCover { get; set; }
        public string Book_Preview1 { get; set; }
        public string Book_Preview2 { get; set; }
        [DisplayName("Sách Hot")]
        public Boolean IsHot { get; set; }
        [DisplayName("Sách Bán Chạy")]
        public Boolean IsBestSeller { get; set; }
        [DisplayName("Còn Hàng")]
        public int Stock { get; set; }
    }
}