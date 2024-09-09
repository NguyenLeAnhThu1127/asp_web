﻿using BaiTapVeNha2_TaoController.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace BaiTapVeNha2_TaoController.Controllers
{
    public class Tuan02Controller : Controller
    {
        public IActionResult Index()
        {
            ViewBag.HoTen = "Nguyen Le Anh Thu";
            ViewBag.MSSV = "1822040540";
            ViewBag.Nam = 2004;
            return View();
        }
    }

}
    public class Tuan02Controller : Controller
    {

        public IActionResult MayTinh(int a, int b, string pheptinh)
        {
            double PhepTinh;
            if (pheptinh == "cong")
                PhepTinh = a + b;
            else if (pheptinh == "tru")
                PhepTinh = a - b;
            else if (pheptinh == "nhan")
                PhepTinh = a * b;
            else
                PhepTinh = (double)a / b;
            ViewBag.KetQua = PhepTinh;
            return View();
        }
        public IActionResult Profile()
        {
            return View();
        }
    }
