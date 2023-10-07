using Generic_Repository_Pattern.Model.Entity;
using Generic_Repository_Pattern.Relationals;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Generic_Repository_Pattern.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public async Task<IActionResult> Index()
        {
            // Creating sample data ("Id" property auto increment)

            var book = new Book { Name = "Dönüşüm", Author = "Franz Kafka" };
            var book2 = new Book { Name = "Yozgatlı", Author = "Musa Yılmaz" };

            await _bookRepository.Create(book);
            await _bookRepository.Create(book2);

            //BookRepository specific method

            ViewBag.FirstBookName = await _bookRepository.GetFirstBookName();

            //GetAll Books
            var model = _bookRepository.GetAll();

            return View(model);
            
        }
        
        //public IActionResult Error()
        //{
        //    return View( new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        //}
    }
}
