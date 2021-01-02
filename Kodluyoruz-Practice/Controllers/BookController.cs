using Kodluyoruz_Practice.Entities;
using Kodluyoruz_Practice.Models;
using Kodluyoruz_Practice.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kodluyoruz_Practice.Controllers
{
    public class BookController : Controller
    {
        #region Injections
        private readonly BookService _bookService;
        public BookController(BookService bookService)
        {
            _bookService = bookService;
        } 
        #endregion
        public IActionResult Index()
        {
            var bookEntities = _bookService.GetBooks();
            var bookViewModelList = new List<BookViewModel>();

            foreach (var entity in bookEntities)
            {
                bookViewModelList.Add(new BookViewModel
                {
                    Id = entity.Id,
                    Author = entity.Author,
                    Name = entity.Name,
                    Publisher = entity.Publisher

                });
            }

            return View(bookViewModelList);

        } 
        public IActionResult Edit(int id)
        {

            var bookEntity = _bookService.Get(id);
            var model = new BookViewModel()
            {
                Id = bookEntity.Id,
                Name = bookEntity.Name,
                Publisher = bookEntity.Publisher,
                Author=bookEntity.Author
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Edit(BookViewModel model)
        {
            var bookEntity = new BookEntity
            {
                Id=model.Id,
                Name=model.Name,
                Author=model.Author,
                Publisher=model.Publisher
            };
            _bookService.Edit(bookEntity);
            var updatedEntity=_bookService.Get(model.Id);
            var updatedBookViewModel = new BookViewModel
            {
                Id = updatedEntity.Id,
                Name=updatedEntity.Name,
                Author=updatedEntity.Author,
                Publisher=updatedEntity.Publisher
            };
            return View(updatedBookViewModel);
            
        }
        public IActionResult Delete(int id)
        {
            _bookService.Delete(id);
            return RedirectToAction(nameof(Index), "Book");
        }
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(BookViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            var entity = new BookEntity
            {
                Id = model.Id,
                Name = model.Name,
                Author = model.Author,
                Publisher = model.Publisher
            };
            _bookService.Add(entity);
            return RedirectToAction(nameof(Index), "Book");
        }

    }
}
