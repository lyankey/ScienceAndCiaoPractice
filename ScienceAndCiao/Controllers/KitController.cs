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
        }
    }
}