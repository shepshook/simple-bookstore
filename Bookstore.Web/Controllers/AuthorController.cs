using System;
using Bookstore.Core.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Web.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IAuthorRepository _repository;
    
        public AuthorController(IAuthorRepository repository) => _repository = repository;

        [Route("authors")]
        public IActionResult List()
        {
            return View(_repository.All());
        }

        [Route("[controller]/[action]/{id:guid}")]
        public IActionResult Details(Guid id)
        {
            var author = _repository.Get(id);
            return author == null ? (IActionResult) NotFound() : View(author);
        }
    }
}