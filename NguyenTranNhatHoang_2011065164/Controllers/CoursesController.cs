using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NguyenTranNhatHoang_2011065164.Models;
using NguyenTranNhatHoang_2011065164.ViewModels;
using Microsoft.AspNet.Identity;

namespace NguyenTranNhatHoang_2011065164.Controllers
{
    public class CoursesController : Controller
    {
        private readonly ApplicationDbContext dbContext;
        public CoursesController()
        {
            dbContext = new ApplicationDbContext();
        }
        // GET: Courses
        //[Authorize]
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = dbContext.Categories.ToList()
        };
            return View(viewModel);
        }

        //[Authorize]
        [HttpPost]
        public ActionResult Create(CourseViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                viewModel.Categories = dbContext.Categories.ToList();
                return View("Create", viewModel);
            }
            var course = new Course
            {
                LectuereId = User.Identity.GetUserId(),
                DateTime = viewModel.GetDateTime(),
                CategoryId = viewModel.Category,
                Place = viewModel.Place
            };
            dbContext.Courses.Add(course);
            dbContext.SaveChanges();
            return RedirectToAction("Index","Home");
        }
    }
}