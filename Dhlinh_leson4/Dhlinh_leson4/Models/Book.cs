using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace Dhlinh_leson4.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int AuthorId { get; set; }
        public int GenreId { get; set; }
        public string Image { get; set; }
        public float Price { get; set; }
        public int TotalPage { get; set; }
        public string Sumary { get; set; }
        // danh sách các cuốn sách (nhớ using System.Collections.Generic)
        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
        {
            new Book()
            {
                Id = 1,
                Title = "Chí Phèo",
                AuthorId = 1,
                GenreId = 1,
                Image = "/images/products/b1.jpg",
                Price = 500000,
                Sumary = "Tác phẩm kinh điển của nhà văn Nam Cao viết về người nông dân trước cách mạng.",
                TotalPage = 250
            },
            new Book()
            {
                Id = 2,
                Title = "Số Đỏ",
                AuthorId = 2,
                GenreId = 2,
                Image = "/images/products/b2.jpg",
                Price = 120000,
                Sumary = "Tiểu thuyết trào phúng nổi tiếng của nhà văn Vũ Trọng Phụng.",
                TotalPage = 280
            },
            new Book()
            {
                Id = 3,
                Title = "Tắt Đèn",
                AuthorId = 3,
                GenreId = 1,
                Image = "/images/products/b3.jpg",
                Price = 95000,
                Sumary = "Hiện thực cuộc sống khốn khổ của tầng lớp nông dân dưới thời thực dân phong kiến.",
                TotalPage = 200
            },
            new Book()
            {
                Id = 4,
                Title = "Dế Mèn Phiêu Lưu Ký",
                AuthorId = 4,
                GenreId = 3,
                Image = "/images/products/b4.jpg",
                Price = 150000,
                Sumary = "Cuộc phiêu lưu kỳ thú của chú Dế Mèn qua thế giới loài vật.",
                TotalPage = 210
            }
        };

            return books;
        }
        public Book GetBookById(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        // SelectListItem Authors (nhớ using Microsoft.AspNetCore.Mvc.Rendering)
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Nam cao"},
            new SelectListItem {Value="2", Text="Ngô Tất Tố"},
            new SelectListItem {Value="3", Text="Adamkhoom"},
            new SelectListItem {Value="4", Text="Thiền sư Thích Nhất Hạnh"}
        };

                // SelectListItem Genres
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Truyện tranh"},
            new SelectListItem {Value="2", Text="Văn học đương đại"},
            new SelectListItem {Value="3", Text="Phật học phổ thông"},
            new SelectListItem {Value="4", Text="Truyện cười"}
        };
    }
}

