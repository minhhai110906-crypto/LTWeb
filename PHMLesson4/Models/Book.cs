using Microsoft.AspNetCore.Mvc.Rendering;

namespace PHMLesson4.Models
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

        public List<Book> GetBookList()
        {
            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    Title = "Chi Pheo",
                    AuthorId = 1,
                    GenreId= 1,
                    Image = "/images/products/b1.jpg",
                    Price = 500000,
                    Sumary = "",
                    TotalPage = 250
                },
                new Book()
                {
                    Id = 2,
                    Title = "Lao Hac",
                    AuthorId = 2,
                    GenreId = 1,
                    Image = "/images/products/b2.jpg",
                    Price = 400000,
                    Sumary = "",
                    TotalPage = 200
                }
            };
            return books;
        }
        public Book GetBookByID(int id)
        {
            Book book = this.GetBookList().FirstOrDefault(b => b.Id == id);
            return book;
        }
        public List<SelectListItem> Authors { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Nam Cao"},
            new SelectListItem {Value="2", Text="Nam Cao"},
        };
        public List<SelectListItem> Genres { get; } = new List<SelectListItem>
        {
            new SelectListItem {Value="1", Text="Tiểu thuyết"},
            new SelectListItem {Value="2", Text="Truyện ngắn"},
        };
    }
}
