using ITSE1430.MovieLib;
using ITSE1430.MovieLib.Sql;
using Movie.Mvc.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Movie.Mvc.Controllers
{
    public class MovieController : Controller
    {
        public MovieController ()
        {
            var connString = ConfigurationManager.ConnectionStrings["MovieDatabase"];

            _database = new SqlMovieDatabase(connString.ConnectionString);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var items = _database.GetAll();

            return View(items.Select(i => new MovieModel(i)));
        }

        [HttpGet]
        public ActionResult Create()
        {
            var model = new MovieModel();

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(MovieModel model)
        {
            if(ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();

                    _database.Add(item);

                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }

            };

            return View(model);
        }

        [HttpGet]
        public ActionResult Edit( string id )
        {
            var item = _database.GetAll().FirstOrDefault(i => i.Name == id);

            return View(new MovieModel(item));
        }

        [HttpPost]
        public ActionResult Edit(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var item = model.ToDomain();

                    var exsisting = _database.GetAll().FirstOrDefault(i => i.Name == model.Name);

                    _database.EditCore(exsisting.Name, item);

                    return RedirectToAction("Index");
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("", e.Message);
                }

            };

            return View(model);
        }

        private readonly IMovieDatabase _database;
    }
}