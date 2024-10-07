using System.ComponentModel.DataAnnotations;

namespace BaiKiemTra03_02.Models
{
    public class Author
    {
         
        [Key]
        public int AuthorId { get; set; }

        [Required(ErrorMessage = "Tên tác giả không được để trống.")]
        public string AuthorName { get; set; }

        [Required(ErrorMessage = "Quốc tịch không được để trống.")]
        public string Nationality { get; set; }

        [Required(ErrorMessage = "Năm sinh không được để trống.")]
        public int BirthYear { get; set; }
    }
}
