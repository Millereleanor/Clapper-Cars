using ClappersCars.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ClappersCars.Controllers
{
    public class UserRequestFormsController : Controller
    {
        private ClappersCarsContext db = new ClappersCarsContext();

        // GET: UserRequestForms
        [Authorize]
        public ActionResult Index()
        {
            var userRequestForms = db.UserRequestForms.Include(u => u.Vehicle);
            return View(userRequestForms.ToList());
        }

        // GET: UserRequestForms/Details/5
        [Authorize]
        public ActionResult Details(int? id)//todo:elle conect to partial view
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRequestForm userRequestForm = db.UserRequestForms.Find(id);
            if (userRequestForm == null)
            {
                return HttpNotFound();
            }
            return View(userRequestForm);
        }

        // GET: UserRequestForms/Create
        public ActionResult Create()
        {
            ViewBag.VehicleID = new SelectList(db.Vehicles, "VehicleID", "Make");
            return View();
        }

        // POST: UserRequestForms/Create
        [HttpPost]
        public ActionResult Create(UserRequestForm userRequestForm)
        {
            if (ModelState.IsValid)
            {
                db.UserRequestForms.Add(userRequestForm);
                db.SaveChanges();
                return RedirectToAction("Index", "Vehicles");
            }

            ViewBag.VehicleID = new SelectList(db.Vehicles, "VehicleID", "Make", userRequestForm.VehicleID);
            return View(userRequestForm);
        }

        // GET: UserRequestForms/Edit/5
        [Authorize]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRequestForm userRequestForm = db.UserRequestForms.Find(id);
            if (userRequestForm == null)
            {
                return HttpNotFound();
            }
            ViewBag.VehicleID = new SelectList(db.Vehicles, "VehicleID", "Make", userRequestForm.VehicleID);
            return View(userRequestForm);
        }

        // POST: UserRequestForms/Edit/5
        [Authorize]
        [HttpPost]
        public ActionResult Edit(UserRequestForm userRequestForm)
        {
            if (ModelState.IsValid)
            {
                db.Entry(userRequestForm).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.VehicleID = new SelectList(db.Vehicles, "VehicleID", "Make", userRequestForm.VehicleID);
            return View(userRequestForm);
        }

        // GET: UserRequestForms/Delete/5
        [Authorize]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            UserRequestForm userRequestForm = db.UserRequestForms.Find(id);
            if (userRequestForm == null)
            {
                return HttpNotFound();
            }
            return View(userRequestForm);
        }

        // POST: UserRequestForms/Delete/5
        [Authorize]
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            UserRequestForm userRequestForm = db.UserRequestForms.Find(id);
            db.UserRequestForms.Remove(userRequestForm);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}