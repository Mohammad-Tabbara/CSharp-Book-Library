using BookLibrary.Models;
using BookLibrary.Services;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BookLibrary.Controllers
{
    public class RentBookController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        public string NULL { get; private set; }

        [Authorize]
        // GET: RentBook
        public ActionResult Index()
        {
             return View(db.Book.ToList());
        }

        //public static bool IsAdministrator()
        //{
        //    string[] rolesuserbelongto = Roles.GetRolesForUser();
        //    for(int i = 0; i<rolesuserbelongto.Count();i++)
        //    {
        //        if(rolesuserbelongto[i] == "Admin")
        //        {
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        [Authorize(Roles = "Admin")]
        public ActionResult AdminList()
        {
            return View(db.Book.ToList());
        }

        [Authorize]
        // GET: RentBook/Details
        public ActionResult Details(int id)
        {
            var rentBook = db.Book.Where(b => b.Id == id).First();
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

                var service = new BookService(HttpContext.GetOwinContext().Get<ApplicationDbContext>());
                service.CreateBook(collection["BookName"],(Convert.ToDecimal(collection["RentPrice"])));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize]
        public ActionResult Book(int id)
        {
            var userId = User.Identity.GetUserId();
            var oldBookId = db.UserBookRelation.Where(u => u.ApplicationUserId == userId).First().BookId;
            string bookUserId = null;
            try
            {
                if (db.Book.Where(b => b.Id == oldBookId).Count() != 0)
                {
                    bookUserId = db.Book.Where(b => b.Id == id).First().ApplicationUserId;
                    if (bookUserId != userId)
                    {
                        db.Book.Where(b => b.Id == oldBookId).First().ApplicationUserId = null;
                    }
                }
                if (bookUserId == null || bookUserId == userId )
                {
                    db.Book.Where(b => b.Id == id).First().ApplicationUserId = userId;
                    db.UserBookRelation.Where(u => u.ApplicationUserId == userId).First().BookId = id;
                    db.UserBookRelation.Where(u => u.ApplicationUserId == userId).First().UpdatedAt = DateTime.Now.ToString();
                    db.SaveChanges();
                    return Redirect(Request.UrlReferrer.ToString());
                }
                return Content("Book Already Rented By someone Else.");
            }
            catch
            {
                return Content("Failed to Book Contact Support");
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: RentBook/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: RentBook/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var book = db.Book.Where(b => b.Id == id).First();
                book.BookName = collection["BookName"]; 
                book.RentPrice = Convert.ToDecimal(collection["RentPrice"]);
                book.UpdatedAt = DateTime.Now.ToString();
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        [Authorize(Roles = "Admin")]
        // GET: RentBook/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            var book = db.Book.Where(b => b.Id == id).First();
            db.Book.Remove(book);
            db.SaveChanges();
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
