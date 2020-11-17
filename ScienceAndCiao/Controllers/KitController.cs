using ScienceAndCiao.Models;
using ScienceAndCiao.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ScienceAndCiao.Controllers
{
    public class KitController : Controller
    {
        public ApplicationDbContext _context;
        public KitController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose (bool disposing)
        {
            _context.Dispose();
        }
        public ViewResult Index()
        {
            var kits = _context.Kits.Include(m => m.Branch).ToList();

            return View(kits);
        }

        public ActionResult Details(int id)
        {
            var kit = _context.Kits.Include(m => m.Branch).SingleOrDefault(m => m.Id == id);
            if (kit == null)
                return HttpNotFound();

            return View(kit);
        }

            // GET: Kit/Random

            public ActionResult Random()
        {
            var kit = new Kit() { Name = "First Kit" };
            //var viewResult = new ViewResult();
            //the viewdata is not a regular dictionary, you use it as key value pairs or as model object
            var members = new List<Member>
            {
                new Member { Name = "Member 1"},
                new Member { Name = "Member 2"}
            };

            var viewModel = new RandomKitViewModel
            {
                Kit = kit,
                Members = members
            };
            return View(viewModel);

            //the below are older ways that are not good choices - you have to update the @view if you use the below
            //ViewData["Kit"] = kit;
            //ViewBag.RandomKit = kit;
            //return View();

            //other return options below:
            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home", new {page = 1, sortBy = "name"} ); //(naming the action and controller, and third is the optional arguments to appear as part of the query string)
        }
        //attribute route
        //to look up attribute contraints look up asp.net MVC Attribute Route Constraints
        [Route("kit/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
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