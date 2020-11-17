using ScienceAndCiao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using ScienceAndCiao.ViewModels;

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

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new MemberFormViewModel
            {
                MembershipTypes = membershipTypes
            };
            return View("MemberForm", viewModel);
        }

        [HttpPost]
        public ActionResult Create(Member member)
        {
            _context.Members.Add(member);
            _context.SaveChanges();
            return RedirectToAction("Index", "Members");
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

        public ActionResult Edit(int id)
        {
            var member = _context.Members.SingleOrDefault(c => c.Id == id);
            if (member == null)
                return HttpNotFound();

            var viewModel = new MemberFormViewModel
            {
                Member = member,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("MemberForm", viewModel);
        }

    }
}