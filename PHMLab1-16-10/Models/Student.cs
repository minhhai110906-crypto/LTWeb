using System.ComponentModel.DataAnnotations;

namespace PHMLab1_16_10.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "Họ tên")]
        [Required(ErrorMessage = "Họ tên bắt buộc phải được nhập!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên phải từ 4 đến 100 ký tự!")]
        public string? Name { get; set; }
        [Display(Name = "Địa chỉ Email")]
        [Required(ErrorMessage = "Email bắt buộc phải được nhập!")]
        [RegularExpression(@"^[A-Za-z0-9._%+-]+@gmail\.com$", ErrorMessage = "Email phải có đuôi @gmail.com!")]
        public string? Email { get; set; }
        [Display(Name = "Mật khẩu")]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập!")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải từ 8 ký tự trở lên!")]
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$",
            ErrorMessage = "Mật khẩu phải có ít nhất 1 ký tự viết hoa, 1 ký tự viết thường, 1 chữ số và 1 ký tự đặc biệt!")]
        public string? Password { get; set; }
        [Display(Name = "Khoa/Ngành")]
        [Required(ErrorMessage = "Vui lòng chọn Khoa!")]
        public Branch? Branch { get; set; }
        [Display(Name = "Giới tính")]
        [Required(ErrorMessage = "Vui lòng chọn Giới tính!")]
        public Gender? Gender { get; set; }
        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }
        [Display(Name = "Địa chỉ")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập!")]
        public string? Address { get; set; }
        [Display(Name = "Ngày sinh")]
        [Range(typeof(DateTime), "1/1/1963", "12/31/2008", ErrorMessage = "Ngày sinh phải từ năm 1963 đến 2008!")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Ngày sinh bắt buộc phải được nhập!")]
        public DateTime DateOfBorth { get; set; }
        [Display(Name = "Điểm trung bình")]
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập!")]
        [Range(0.0, 10.0, ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0!")]
        public double? Score { get; set; }
    }
}
