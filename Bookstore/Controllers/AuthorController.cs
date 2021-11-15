using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bookstore.Models;
using Bookstore.Models.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class AuthorController : Controller
    {
        private readonly IBookstoreRepository<Author> authorRepositry;

        public AuthorController(IBookstoreRepository<Author> AuthorRepositry)
        {
            this.authorRepositry = AuthorRepositry;
        }
        // GET: Author
        public ActionResult Index()
        {
            var authors = authorRepositry.List();
            return View(authors);
        }

        // GET: Author/Details/5
        public ActionResult Details(int id)
        {
            var authorId = authorRepositry.Find(id);
            return View(authorId);
        }

        // GET: Author/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Author/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Author newAuthor)
        {
            try
            {
                authorRepositry.Add(newAuthor);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Edit/5
        public ActionResult Edit(int id)
        {
            var author = authorRepositry.Find(id);
            return View(author);
        }

        // POST: Author/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Author author)
        {
            try
            {

               authorRepositry.Update(id, author);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Author/Delete/5
        public ActionResult Delete(int id)
        {

            var author = authorRepositry.Find(id);
            return View(author);
        }

        // POST: Author/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                authorRepositry.Delete(id);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}