using School_Management_System_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School_Management_System_Project.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, FirstName = "John", LastName = "Doe", DateOfBirth = new DateTime(2000, 1, 1), Email = "SahdevRathod@gmail.com" },
                new Student { Id = 2, FirstName = "Jane", LastName = "Smith", DateOfBirth = new DateTime(2001, 2, 2), Email = "JaneSmit@gmail.com", },
                new Student { Id = 3, FirstName = "Michael", LastName = "Johnson", DateOfBirth = new DateTime(2002, 3, 3), Email = "Michael@gmail.com" }
            };

            return View();
        }
    }
}