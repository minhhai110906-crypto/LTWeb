using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PHMLesson7.Models
{
    public class Member
    {
        public int Id { get; set; }
        [DisplayName("Tài khoản")]
        [Required(ErrorMessage = "Tài khoản không được để trống !")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Tài khoản có độ dài trong khoảng 3-20 ký tự")]
        public string UserName { get; set; }
        [DisplayName("Mật khẩu")]
        [StringLength(100, MinimumLength = 8, ErrorMessage = "Mật khẩu phải có tối thiểu 8 ký tự")]
        public string Password { get; set; }
        [DisplayName("Email")]
        [Required(ErrorMessage = "Email khoản không được để trống !")]
        [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage ="Email phải đúng định dạng")]
        public string Email { get; set; }
        [DisplayName("Số điện thoại")]
        [Required(ErrorMessage = "Bạn chưa nhập số điện thoại !")]
        [RegularExpression(@"^0\d{9}", ErrorMessage = "Điện thoải phải là 10 số, bắt đầu bằng 0")]
        public string Phone { get; set; }

    }
}
