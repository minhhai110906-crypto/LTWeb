using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PHMLesson9.Models
{
    [Table("Banner")]
    public class Banner
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Tên banner không được để trống")]
        [StringLength(100)]
        [Display(Name = "Tên Banner")]
        public string Name { get; set; } = string.Empty;

        [Display(Name = "Trạng thái")]
        public byte Status { get; set; } = 1;

        [Display(Name = "Độ ưu tiên")]
        public int Prioty { get; set; } = 0;

        [StringLength(100)]
        [Display(Name = "Ảnh")]
        public string? Image { get; set; }

        [StringLength(350)]
        [Display(Name = "Mô tả")]
        public string? Description { get; set; }
    }
}