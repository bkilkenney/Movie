using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller   //Added this controller which provides methods(actions)
                                                //MoviesController derives from Controller class(Inherited)
    {
        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };        //Creating object from the Movie class
                                                                //This will usually come from a DB but were just building from scratch
            return View(movie);  //(movie) is the model
        }
    }
}