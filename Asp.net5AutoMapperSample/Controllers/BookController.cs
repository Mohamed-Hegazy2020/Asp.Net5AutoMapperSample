using Asp.net5AutoMapperSample.Data;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using net5AutoMapperSample.Models;
using net5AutoMapperSample.ModelsView;
using System.Collections.Generic;
using System.Linq;

namespace Asp.net5AutoMapperSample.Controllers
{
    public class BookController : Controller
    {
        private readonly IMapper _mapper;
        private readonly AppDatabaseContext _context;

        public BookController(IMapper mapper, AppDatabaseContext context)
        {
            _mapper = mapper;
            _context = context;
        }
        // GET: BookController
        public ActionResult Index()
        {
            var books = _context.Books.AsQueryable().Include("Author").ToList();
            var booksV=_mapper.Map<List<BookMV>>(books);

            return View(booksV);
        }

        // GET: BookController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View(new BookMV());
        }

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(BookMV vm)
        {
            try
            {
                var book = _mapper.Map<Book>(vm);
                _context.Books.Add(book);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
