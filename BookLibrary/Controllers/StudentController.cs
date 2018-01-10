using BookLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookLibrary.Controllers
{
    public class StudentController : Controller
    {

        private ApplicationDbContext db = new ApplicationDbContext();

        [Authorize(Roles = "Admin")]
        // GET: Student
        public ActionResult Index()
        {
            return View(db.UserBookRelation.ToList());
        }

        [Authorize(Roles = "Admin")]
        // GET: Student/Details/5
        public ActionResult Details(int id)
        {
            return View(db.UserBookRelation.Where(ur => ur.Id == id).First());
        }

        //[Authorize(Roles = "Admin")]
        //// GET: Student/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //[Authorize(Roles = "Admin")]
        //// POST: Student/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        [Authorize(Roles = "Admin")]
        // GET: Student/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        // POST: Student/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
                var userBookRelation = db.UserBookRelation.Where(ub => ub.Id == id).First();
                userBookRelation.FirstName = collection["FirstName"];
                userBookRelation.LastName = collection["LastName"];
                userBookRelation.BookId = Convert.ToInt32(collection["BookId"]);
                userBookRelation.UpdatedAt = DateTime.Now.ToString();
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin")]
        // POST: Student/Delete/5
        public ActionResult Delete(int id)
        {
            var userBookRelation = db.UserBookRelation.Where(b => b.Id == id).First();
            var deletedUserId = userBookRelation.ApplicationUserId;
            var student = db.Users.Where(u => u.Id == deletedUserId).First();
            db.Users.Remove(student);
            db.UserBookRelation.Remove(userBookRelation);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
