using System;
using System.Collections.Generic;
using Bookstore.Core.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Bookstore.Web.ViewModels
{
    public class BookListViewModel
    {
        public IEnumerable<Book> Books { get; set; }
        public SelectList Publishers { get; set; }
        public Guid? CurrentPublisher { get; set; }
    }
}