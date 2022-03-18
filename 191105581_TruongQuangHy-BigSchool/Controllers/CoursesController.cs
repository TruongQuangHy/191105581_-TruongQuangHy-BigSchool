using _191105581_TruongQuangHy_BigSchool.Models;
using _191105581_TruongQuangHy_BigSchool.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _191105581_TruongQuangHy_BigSchool.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationException _dbContext;
        public CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Create  ()
        {
            var viewModel = new CourseViewModel()
            {
            };
            return View();
        }
    }
}