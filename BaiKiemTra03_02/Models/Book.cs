using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BaiKiemTra03_02.Models
{
    public class Book
    {
        public Book(Author author)
        {
            Author = author;
        }

        [Key]
        public int BookId { get; set; } 

        [Required(ErrorMessage = "Tiêu đề sách không được để trống!")]
        public string Title { get; set; } 

        [Required(ErrorMessage = "Năm xuất bản không được để trống!")]
        public int PublicationYear { get; set; } 

        [Required(ErrorMessage = "Mã tác giả không được để trống!")]
        public int AuthorId { get; set; } 

        [ForeignKey("AuthorId")]
        public Author Author { get; set; } 

        [Required(ErrorMessage = "Thể loại không được để trống!")]
        public int TheLoaiId { get; set; }

        [ForeignKey("TheLoaiId")]
        [ValidateNever]
        public TheLoai TheLoai { get; set; } 

        [Required(ErrorMessage = "Thể loại sách không được để trống!")]
        public string Genre { get; set; }
    }

}
