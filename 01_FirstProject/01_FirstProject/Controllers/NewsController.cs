using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstProject.Controllers
{
    public class NewsController : Controller
    {
        /*
        // GET: NewController
        public ActionResult Index()
        {
            return View();
        }

        // GET: NewController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: NewController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NewController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: NewController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: NewController/Edit/5
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

        // GET: NewController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: NewController/Delete/5
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
        */
        public IActionResult Index()
        {
            var articles = new List<Article> { 
                new Article{Id=1, Title="Title 01", Content="This is content article 01", Author="ClientBNC"},
                new Article{Id=2, Title="Title 02", Content="This is content article 02", Author="ClientBNC"},
                new Article{Id=3, Title="Title 03", Content="This is content article 03", Author="ClientBNC"},
                new Article{Id=4, Title="Title 04", Content="This is content article 04", Author="ClientBNC"},
                new Article{Id=5, Title="Title 05", Content="This is content article 05", Author="ClientBNC"},
                new Article{Id=6, Title="Title 06", Content="This is content article 06", Author="ClientBNC"},
                new Article{Id=7, Title="Title 07", Content="This is content article 07", Author="ClientBNC"},
                new Article{Id=8, Title="Title 08", Content="This is content article 08", Author="ClientBNC"},
            };
            // Option 1: Using ViewBag
            //ViewBag.Articles = articles;

            // Option 2: Using ViewData
            //ViewData["Articles"] = articles;
            //return View();

            // Option 3: Using Model
            return View(articles);

        }
        public String StringOut(int id, Employee e)
        {
            return ($"Say Hello from Binh is number: {id} - firstname: {e.FirstName} - lastname: {e.LastName}");
        }
        public IActionResult StringOut2(int id, Employee e)
        {
            return Content($"Say Hello from Binh is number: {id} - firstname: {e.FirstName} - lastname: {e.LastName}");
        }
        public IActionResult JsonOut(int id, Employee e)
        {
            var obj = new { Id = id, Employee = e };
            return Json(obj);
        }
    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
    }
}
