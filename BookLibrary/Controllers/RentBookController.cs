using BookLibrary.Models;
using BookLibrary.Services;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class RentBookController : Controller
    {
        // GET: RentBook
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        // GET: RentBook/Details
        public ActionResult Details()
        {
            var rentBook = new Book { BookName="King Arther", RentPrice=0.5m };
            return View(rentBook);
        }

        [Authorize(Roles = "Admin")]
        // GET: RentBook/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RentBook/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here
                var service = new BookService(HttpContext.GetOwinContext().Get<ApplicationDbContext>());
                service.CreateBook(collection["BookName"],(Decimal.Parse(collection["RentPrice"])));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RentBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RentBook/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: RentBook/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RentBook/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
