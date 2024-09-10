using BaiTapKiemTra01.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BaiTapKiemTra01.Controllers
{
    public class SanPhamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BaiTap2()
        {
            var sanpham = new SanPhamViewModel();
            ViewBag.TenSP = "Giày Adidas";
            ViewBag.Gia = "3.000.000VND";
            return View(sanpham);
        }

    }
}
