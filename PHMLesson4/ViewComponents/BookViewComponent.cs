using Microsoft.AspNetCore.Mvc;
using PHMLesson4.Models;

namespace PHMLesson4.ViewComponents
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
