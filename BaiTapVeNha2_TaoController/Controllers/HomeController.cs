using BaiTapVeNha2_TaoController.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BaiTapVeNha2_TaoController.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyễn Lê Anh Thư";
            ViewBag.MSSV = "1822040540";
            return View();
        }
    }
}
