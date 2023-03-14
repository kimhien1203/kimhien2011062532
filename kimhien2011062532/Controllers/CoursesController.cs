using kimhien2011062532.Models;
using Microsoft.AspNet.Identity.Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace kimhien2011062532.Controllers
{
    public class CoursesController : Controller
    {
      
        private readonly ApplicationDbContext_context;
         public CoursesController()
        {
            _context = new ApplicationDbContext();

        }
        // GET: Courses
        public ActionResult Create()
        {
            var ViewModel = new CoursesController
            {
                Categories = _context.Categories.ToList()
            };
            return View();
        }
    }
}