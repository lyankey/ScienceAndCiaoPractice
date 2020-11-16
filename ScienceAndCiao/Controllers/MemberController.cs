using ScienceAndCiao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace ScienceAndCiao.Controllers
{
    public class MemberController : Controller
    {
        private ApplicationDbContext _context;
        public MemberController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            {
                _context.Dispose();
            }
        }
        // GET: Member
        public ViewResult Index()
        {
            var members = _context.Members.Include(c => c.MembershipType).ToList();
            return View(members);
        }

        public ActionResult Details(int id)
        {
            var member = _context.Members.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == id);

            if (member == null)
                return HttpNotFound();
            return View(member);
        }

    }
}