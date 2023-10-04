using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ThongTinSinhVien.Models
{
	public class Student
	{
		public int Id { get; set; }//Mã sinh viên
		[StringLength(100, MinimumLength = 4,ErrorMessage ="Tên phải có hơn 4 ký tự")]
		[Required(ErrorMessage ="Tên bắt buộc phải được nhập")]
        public string? Name { get; set; } //Họ tên
		[Required(ErrorMessage ="Email bắt buộc phải được nhập")]
		[RegularExpression(@"^[a-zA-Z0-9._%+-]+@gmail.com$", ErrorMessage ="Email nhập không đúng định dạng")]
		public string? Email { get; set; } //Email
		[StringLength(100,MinimumLength =8,ErrorMessage = "Mật khẩu phải có hơn 8 ký tự")]
		[RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[~!@#$%^&*()_+{}|:\""<>?/]).*$", ErrorMessage = "Mật khẩu phải chứa ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
		[Required(ErrorMessage ="Mật khẩu bắt buộc phải được nhập")]
		public string? Password { get; set; }//Mật khẩu
		[Required(ErrorMessage ="Ngành phải được chọn")]
		public Branch? Branch { get; set; }//Ngành học
		[Required(ErrorMessage = "Giới tính phải được chọn")]
		public Gender? Gender { get; set; }//Giới tính
        public bool IsRegular { get; set; }//Hệ: true-chính qui, false-phi cq
		[DataType(DataType.MultilineText)]
		[Required(ErrorMessage = "Địa chỉ phải được nhập")]
		public string? Address { get; set; }//Địa chỉ
		[Range(typeof(DateTime), "1/1/1963", "12/31/2005",ErrorMessage ="Ngày sinh không hợp lệ")]
		[DataType(DataType.Date)]
		[Required(ErrorMessage = "Ngày sinh phải được chọn")]
		public DateTime DateOfBorth { get; set; }//Ngày sinh
		[Range(typeof(double),"0.0","10.0", ErrorMessage = "Điểm phải nằm trong khoảng từ 0.0 đến 10.0")]
		[Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
		public double? mark {  get; set; }//Điểm
	}
}
