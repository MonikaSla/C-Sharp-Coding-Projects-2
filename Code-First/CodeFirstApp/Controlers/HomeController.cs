using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CodeFirstApp.Models;

namespace CodeFirstApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Instructor()
        {
            using (var context = new CodeFirstAppContext())
            {
                List<Instructor> instructors = new List<Instructor>
                {
                    new Instructor
                    {
                    Id = 1,
                    FirstName = "Siuming",
                    LastName = "Dai"
                    },

                    new Instructor
                    {
                    Id = 2,
                    FirstName = "Cathy",
                    LastName = "Cat"
                    },

                    new Instructor
                    {
                    Id = 3,
                    FirstName = "Joyce",
                    LastName = "Pain"
                    }
                };
                instructors.ForEach(s => context.Instructors.Add(s));
                context.SaveChanges();

                return View(instructors);
            }
            

            
        }

        public ActionResult Student()
        {
            using (var context = new CodeFirstAppContext())
            {
                List<Student> students = new List<Student>
                {
                    new Student
                    {
                    Id = 1,
                    FirstName = "Johnny",
                    LastName = "Walker"
                    },

                    new Student
                    {
                    Id = 2,
                    FirstName = "Bruce",
                    LastName = "Lee"
                    },

                    new Student
                    {
                    Id = 3,
                    FirstName = "Sonny",
                    LastName = "Rain"
                    }
                };
                students.ForEach(s => context.Students.Add(s));
                context.SaveChanges();

                return View(students);
            }

        }
    }
}