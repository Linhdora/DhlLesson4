using Dhlinh_leson4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Dhlinh_leson4.ViewComponents
{
    public class BookViewComponent : ViewComponent
    {
        protected Book book = new Book();
        public IViewComponentResult Invoke()
        {
            var books = book.GetBookList();
            return View(books);
        }
    }
}