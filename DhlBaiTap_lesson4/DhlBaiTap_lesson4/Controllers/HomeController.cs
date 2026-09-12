using DhlBaiTap_lesson4.Data;
using DhlBaiTap_lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DhlBaiTap_lesson4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index(string? category)
        {
            var products = ProductRepository.GetNewestProducts();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category).ToList();
            }

            ViewBag.SelectedCategory = category; // để Partial View biết đang chọn danh mục nào
            return View(products);
        }
        public IActionResult GioiThieu() => View();
        public IActionResult LienHe() => View();
        public IActionResult SanPham() => View();
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
