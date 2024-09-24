using BaiKiemTra02.Data;
using BaiKiemTra02.Models;
using Microsoft.AspNetCore.Mvc;

namespace BaiKiemTra02.Controllers
{
	public class LopHocController : Controller
	{
		private readonly ApplicationDbContext _db;

		public LopHocController(ApplicationDbContext db)
		{
			_db = db; // Khởi tạo đối tượng DbContext
		}

		// Hiển thị danh sách lớp học
		public IActionResult Index()
		{
			var lophoc = _db.LopHoc.ToList(); 
			ViewBag.LopHoc = lophoc; 
			return View(); 
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View(); 
		}

		// Xử lý việc tạo lớp học
		[HttpPost]
		public IActionResult Create(LopHoc lophoc)
		{
			if (ModelState.IsValid)
			{
				_db.LopHoc.Add(lophoc);
				_db.SaveChanges(); 
				return RedirectToAction("Index"); 
			}
			return View(); 
		}

		
		[HttpGet]
		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound(); 
			}
			var lophoc = _db.LopHoc.Find(id); 
			if (lophoc == null)
			{
				return NotFound(); 
			}
			return View(lophoc);
		}

		
		[HttpPost]
		public IActionResult Edit(LopHoc lophoc)
		{
			if (ModelState.IsValid)
			{
				_db.LopHoc.Update(lophoc);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();

        }

		
		[HttpGet]
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound(); 
			}
			var lophoc = _db.LopHoc.Find(id); 
			if (lophoc == null)
			{
				return NotFound();
			}
			return View(lophoc); 
		}

		
		[HttpPost]
		public IActionResult DeleteConfirm(int id)
		{
			var lophoc = _db.LopHoc.Find(id);
			if (lophoc == null)
			{
				return NotFound(); 
			}
			_db.LopHoc.Remove(lophoc); 
			_db.SaveChanges(); 
			return RedirectToAction("Index");
		}

		
		public IActionResult Detail(int id)
			{
				if (id == 0)
				{
					return NotFound();
				}
				var lophoc = _db.LopHoc.Find(id);
				if (lophoc == null)
				{
					return NotFound();
				}
				return View(lophoc);
			}
	}
}
