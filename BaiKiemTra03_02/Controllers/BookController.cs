using BaiKiemTra03_02.Data;
using BaiKiemTra03_02.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

//namespace BaiKiemTra03_02.Controllers
//{
//    public class BookController : Controller
//    {
       
//    //[Area("Author")]
//    //    [Authorize(Roles = "Author")] // Chỉ cho phép người dùng có vai trò Admin
       
//            private readonly ApplicationDbContext _db;

//            public BookController(ApplicationDbContext db)
//            {
//                _db = db;
//            }

//            // Hiển thị danh sách sách
//            public IActionResult Index()
//            {
//                var books = _db.Books.Include(b => b.Author).Include(b => b.Genre).ToList(); // Tải danh sách sách kèm theo thông tin tác giả và thể loại
//                return View(books);
//            }

//            // Tạo mới hoặc chỉnh sửa sách
//            [HttpGet]
//            public IActionResult Upsert(int id = 0)
//            {
//                Book book = new Book();

//                // Lấy danh sách tác giả và thể loại để hiển thị trong dropdown
//                IEnumerable<SelectListItem> authors = _db.Authors.Select(a => new SelectListItem
//                {
//                    Value = a.Id.ToString(),
//                    Text = a.AuthorName
//                });

//                IEnumerable<SelectListItem> genres = _db.Genres.Select(g => new SelectListItem
//                {
//                    Value = g.Id.ToString(),
//                    Text = g.Name
//                });

//                ViewBag.Authors = authors;
//                ViewBag.Genres = genres;

//                if (id == 0)
//                {
//                    return View(book); // Trả về view cho tạo mới
//                }
//                else
//                {
//                    book = _db.Books.Include(b => b.Author).Include(b => b.Genre).FirstOrDefault(b => b.Id == id);
//                    return View(book); // Trả về view cho chỉnh sửa
//                }
//            }

//            // Lưu sách
//            [HttpPost]
//            public IActionResult Upsert(Book book)
//            {
//                if (ModelState.IsValid)
//                {
//                    if (book.Id == 0)
//                    {
//                        _db.Books.Add(book); // Thêm sách mới
//                    }
//                    else
//                    {
//                        _db.Books.Update(book); // Cập nhật sách hiện tại
//                    }
//                    _db.SaveChanges();
//                    return RedirectToAction("Index"); // Quay lại trang danh sách sách
//                }

//                // Nếu không hợp lệ, trả về lại view với dữ liệu nhập
//                return View(book);
//            }

//            // Xóa sách
//            [HttpPost]
//            public IActionResult Delete(int id)
//            {
//                var book = _db.Books.FirstOrDefault(b => b.Id == id);
//                if (book == null)
//                {
//                    return NotFound();
//                }
//                _db.Books.Remove(book);
//                _db.SaveChanges();
//                return Json(new { success = true }); // Trả về kết quả JSON
//            }

//            // Chi tiết sách
//            public IActionResult Details(int id)
//            {
//                var book = _db.Books.Include(b => b.Author).Include(b => b.Genre).FirstOrDefault(b => b.Id == id);
//                if (book == null)
//                {
//                    return NotFound();
//                }
//                return View(book); // Trả về view chi tiết sách
//            }
//        }
//    }


