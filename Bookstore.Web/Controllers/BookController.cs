using System;
using System.Linq;
using Bookstore.Core.Repositories;
using Bookstore.Web.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookstore.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repository;
        private readonly IPublisherRepository _publishers;

        public BookController(IBookRepository repository, IPublisherRepository publishers)
        {
            _repository = repository;
            _publishers = publishers;
        }

        [Route("", Order = 2)]
        public IActionResult List()
        {
            var vm = new BookListViewModel
            {
                Publishers = new SelectList(_publishers.All().Select(x => new {x.Id, x.Name}), "Id", "Name"),
                Books = _repository.All(),
                CurrentPublisher = null
            };
            return View(vm);
        }

        [HttpGet("filter", Order = 1)]
        public IActionResult Filter(Guid? currentPublisher)
        {
            Console.WriteLine(currentPublisher);
            if (!currentPublisher.HasValue)
                return RedirectToAction("List");
            var vm = new BookListViewModel
            {
                Books = _repository.All().Where(x => x.PublisherId == currentPublisher),
                Publishers = new SelectList(_publishers.All().Select(x => new {x.Id, x.Name}), "Id", "Name"),
                CurrentPublisher = currentPublisher
            };
            return View("List",vm);
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var book = _repository.Get(id);
            return book == null ? (IActionResult) NotFound() : View(book);
        }
    }
}