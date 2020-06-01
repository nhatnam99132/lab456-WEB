using Lab4_5_6.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab4_5_6.Controllers
{
    public class CourseController : Controller
    {
        // GET: Course
        private readonly ApplicationDbContext _dbContext;
        public CourseController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            return View();
        }
    }
}