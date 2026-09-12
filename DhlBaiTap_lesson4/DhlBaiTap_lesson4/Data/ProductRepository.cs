using DhlBaiTap_lesson4.Models;

namespace DhlBaiTap_lesson4.Data
{
    public class ProductRepository
    {
            public static List<string> Categories => new()
        {
            "Áo dài", "Áo đông", "Túi xách", "Đồng hồ", "Ví da",
            "Thắt lưng da", "Tủ lạnh", "Tivi", "Quạt điện", "Lò sưởi"
        };

            // Danh sách cho phần "Sản phẩm mới nhất" (hàng trên - load từ Action Index)
            public static List<Product> GetNewestProducts()
            {
                return new List<Product>
            {
                new() { Id = 1,  Name = "Áo dài truyền thống cao cấp",   ImageUrl = "/images/product1.png", Category = "Áo dài" },
                new() { Id = 2,  Name = "Áo dài cách tân",                ImageUrl = "/images/product1.png", Category = "Áo dài" },
                new() { Id = 3,  Name = "Áo đông nam lông vũ",            ImageUrl = "/images/product1.png", Category = "Áo đông" },
                new() { Id = 4,  Name = "Áo đông nữ dạ",                  ImageUrl = "/images/product1.png", Category = "Áo đông" },
                new() { Id = 5,  Name = "Túi xách da thật",               ImageUrl = "/images/product1.png", Category = "Túi xách" },
                new() { Id = 6,  Name = "Túi xách công sở",               ImageUrl = "/images/product1.png", Category = "Túi xách" },
                new() { Id = 7,  Name = "Đồng hồ nam Casio",              ImageUrl = "/images/product1.png", Category = "Đồng hồ" },
                new() { Id = 8,  Name = "Đồng hồ nữ Citizen",             ImageUrl = "/images/product1.png", Category = "Đồng hồ" },
                new() { Id = 9,  Name = "Ví da nam",                      ImageUrl = "/images/product1.png", Category = "Ví da" },
                new() { Id = 10, Name = "Ví da nữ Hàn Quốc",              ImageUrl = "/images/product1.png", Category = "Ví da" },
                new() { Id = 11, Name = "Thắt lưng da cá sấu",            ImageUrl = "/images/product1.png", Category = "Thắt lưng da" },
                new() { Id = 12, Name = "Thắt lưng da bò",                ImageUrl = "/images/product1.png", Category = "Thắt lưng da" },
                new() { Id = 13, Name = "Tủ lạnh Samsung Inverter",       ImageUrl = "/images/product1.png", Category = "Tủ lạnh" },
                new() { Id = 14, Name = "Tủ lạnh LG 2 cánh",              ImageUrl = "/images/product1.png", Category = "Tủ lạnh" },
                new() { Id = 15, Name = "Tivi Sony 43 inch",              ImageUrl = "/images/product1.png", Category = "Tivi" },
                new() { Id = 16, Name = "Tivi Samsung 55 inch",           ImageUrl = "/images/product1.png", Category = "Tivi" },
                new() { Id = 17, Name = "Quạt điện đứng Asia",            ImageUrl = "/images/product1.png", Category = "Quạt điện" },
                new() { Id = 18, Name = "Quạt điện trần Panasonic",       ImageUrl = "/images/product1.png", Category = "Quạt điện" },
                new() { Id = 19, Name = "Lò sưởi dầu Sunhouse",           ImageUrl = "/images/product1.png", Category = "Lò sưởi" },
                new() { Id = 20, Name = "Lò sưởi gốm hồng ngoại",         ImageUrl = "/images/product1.png", Category = "Lò sưởi" },
            };
            }

            // Danh sách riêng cho "Khung sản phẩm phía dưới" (load từ ViewComponent HotProduct)
            public static List<Product> GetHotProducts()
            {
                return new List<Product>
                {
                    new() { Id = 101, Name = "Áo dài lụa cao cấp", ImageUrl = "/images/product1.png", Category = "Áo dài" },
                    new() { Id = 102, Name = "Túi xách mini", ImageUrl = "/images/product1.png", Category = "Túi xách" },
                    new() { Id = 103, Name = "Đồng hồ thông minh", ImageUrl = "/images/product1.png", Category = "Đồng hồ" },
                    new() { Id = 104, Name = "Ví da handmade", ImageUrl = "/images/product1.png", Category = "Ví da" },
                    new() { Id = 105, Name = "Tủ lạnh mini văn phòng", ImageUrl = "/images/product1.png", Category = "Tủ lạnh" },
                    new() { Id = 106, Name = "Quạt điện tích điện", ImageUrl = "/images/product1.png", Category = "Quạt điện" },
                };
            }
        }
}
