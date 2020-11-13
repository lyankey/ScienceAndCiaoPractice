using ScienceAndCiao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScienceAndCiao.Controllers
{
    public class KitController : Controller
    {
        // GET: Kit/Random
        public ActionResult Random()
        {
            var kit = new Kit() { Name = "First Kit" };
            return View(kit);
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"} ); //(naming the action and controller, and third is the optional arguments to appear as part of the query string)
        }

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }


        //a parameter embedding in the URL - to embed in url reference (like "id") must match in RouteConfig parameters, 
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }
        //kit
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;

            if (String.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";

            return Content(String.Format("pageIndex={0}&sortby={1}", pageIndex, sortBy));
        }
        
    }
}