using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CRUD.Models;

namespace CRUD.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private FilmsContext _db = new FilmsContext();

        public ActionResult Index()
        {
            var allFilms = _db.Filmses.ToList();
           //ViewBag.AllFilms = allFilms;
            return View(allFilms);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Films allFilms = _db.Filmses.Single(e => e.Id == Id);
            //ViewBag.AllFilms = allFilms;
            return View(allFilms);
        }

        [HttpPost]
        public ActionResult Edit(Films films)
        {
            _db.Entry(films).State = EntityState.Modified;
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Remove(Films films)
        {
            _db.Entry(films).State = EntityState.Deleted;
            _db.SaveChanges();
            return RedirectToAction("Index");
            //ViewBag.AllFilms = allFilms;
        }

        [HttpGet]
        public ActionResult AddFilm()
        {
            //return RedirectToAction("Index");
            return View();
            //ViewBag.AllFilms = allFilms;
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddFilm(Films films)
        {
            //_db.Filmses.Add(films);
            
            //_db.Filmses.Add(films);


            //_db.Filmses.Add(new Films{Id = 40, Title = "Test2"});
            //_db.Entry(films).State = EntityState.Added;
            _db.Filmses.Add(films);
            _db.SaveChanges();

            
//            if (ModelState.IsValid)
//            {
//                _db.Filmses.Add(films);
//                _db.SaveChanges();
//
//            }

            return RedirectToAction("Index");
        }
    }
}
