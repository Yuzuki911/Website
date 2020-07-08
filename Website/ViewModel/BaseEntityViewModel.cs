using Extension.Extension;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Website.ViewModel
{
    public class BaseEntityViewModel
    {
        public BaseEntityViewModel()
        {
            Id = Guid.NewGuid();
            CreatedDate = GetCurrentDateExtension.GetCurrentTime();
            Description = "";
        }

        [Key]
        public Guid Id { get; set; }
        [DisplayName("Mô Tả Chi Tiết")]
        public string Description { get; set; }
        [DisplayName("Ngày Khởi Tạo")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        public DateTime? CreatedDate { get; set; }
    }
}