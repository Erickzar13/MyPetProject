using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTutorial.Models;

namespace WebTutorial.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shreak!" };

            return View(movie);
        }

        public ActionResult Edit(int Id)
        {
            return Content("id=" + Id);
        }
        
        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "\\" + month + "\\");
        }
    }
}