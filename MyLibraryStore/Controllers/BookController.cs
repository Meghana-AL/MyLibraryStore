using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyLibraryStore.Migrations;
using MyLibraryStore.Models;
using MyLibraryStore.Repository;

namespace MyLibraryStore.Controllers
{
    public class BookController : Controller
    {
        private IBookRepository _bookRepos = null;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepos = bookRepository;
        }
        public IActionResult Index()
        {
            var books = _bookRepos.GetBooks();
            return View(books);
        }
        public IActionResult Details(int id)
        {
            var book = _bookRepos.GetBookById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookDetails book)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.AddBook(book);
            return RedirectToAction("Index", "Book");
        }

        [HttpGet]
        public IActionResult Edit(int Id)
        {
            var book = _bookRepos.GetBookById(Id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BookDetails book,int? id)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            _bookRepos.UpdateBook(id,book);
            return RedirectToAction("Index", "Book");
        }
        [HttpDelete]
        public IActionResult Remove(int id)
        {
            _bookRepos.DeleteBook(id);
            return RedirectToAction("Index", "Book");
        }
        //[NonAction]
        //public IEnumerable<SelectedListItem> GetGenre()
        //{
        //    List<string> genre = new List<string>
        //    {
        //        "Classics","Horror","Comic","Action","Fantasy","Historic Fiction","Romantic"
        //    };
        //    var genres = genre.AsEnumerable().Select(x => new SelectedListItem
        //    {
        //        Text=x,
        //        Value=x
        //    });
        //    return genres;
        //}
    }
}
