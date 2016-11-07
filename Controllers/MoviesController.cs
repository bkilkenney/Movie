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
        // GET: Movies/Random  = Controller/Action
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };  //This will usually come from a DB but were just building from scratch

            return View();



        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


       

           
            
            
            
            
            //Action results below
            
            /*return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });*/  //("Name of the action", "Controller")


            /*return new EmptyResult();*/  
            //return View();
            //return Content("Hello World");  //(movie) is the model
            //return HttpNotFound();

        //These are different results you can get back as your ActionResult



        }
    }
