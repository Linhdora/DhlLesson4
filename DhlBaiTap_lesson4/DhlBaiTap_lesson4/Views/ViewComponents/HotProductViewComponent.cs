using DhlBaiTap_lesson4.Data;
using Microsoft.AspNetCore.Mvc;

namespace DhlBaiTap_lesson4.Views.ViewComponents
{
    public class HotProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string? category)
        {
            var products = ProductRepository.GetHotProducts();

            if (!string.IsNullOrEmpty(category))
            {
                products = products.Where(p => p.Category == category).ToList();
            }

            return View(products);
        }
    }
}
