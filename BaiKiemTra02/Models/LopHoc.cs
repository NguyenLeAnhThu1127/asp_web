using System.ComponentModel.DataAnnotations;


namespace BaiKiemTra02.Models
{
	public class LopHoc 
	{
		[Key] 
		public int Id { get; set; }

        [Required(ErrorMessage = "Không được để trống Tên lớp học!")]
        [StringLength(100, ErrorMessage = "{0} phải có độ dài tối đa {1} ký tự.")]
        [Display(Name = "Tên Lớp Học")]
        public string? TenLopHoc { get; set; }

        [Required(ErrorMessage = "Năm nhập học không được để trống!")]
		[Range(1900, 2100, ErrorMessage = "Năm nhập học phải nằm trong khoảng từ {1} đến {2}.")]
		[Display(Name = "Năm Nhập Học")]
		public int NamNhapHoc { get; set; }

		[Required(ErrorMessage = "Năm ra trường không được để trống!")]
		[Range(1990, 2024, ErrorMessage = "Năm ra trường phải nằm trong khoảng từ {1} đến {2}.")]
		[Display(Name = "Năm Ra Trường")]
		public int NamRaTruong { get; set; }

		[Required(ErrorMessage = "Số lượng sinh viên không được để trống!")]
		[Range(1, 1000, ErrorMessage = "Số lượng sinh viên phải từ {1} đến {2}.")]
		[Display(Name = "Số Lượng Sinh Viên")]
		public int SoLuongSinhVien { get; set; }
	}
}
