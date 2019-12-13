using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class StudentController : Controller
    {
        public ViewResult Details()
        {
            ViewBag.Title = "Student Details Page";
            ViewBag.Header = "Student Details";

            //Student Basic Details
            Student std = new Student()
            {
                StudentId = 999,
                Name = "Jonathan",
                Branch = "CSE",
                Section = "XXX",
                Gender = "Male"
            };

            Address add = new Address()
            {
                StudentId = 999,
                City = "Rock City",
                State = "Alternative",
                Country = "Rock",
                PIN = "KMZWAY87AA"
            };

            //Creating the View Model
            StudentDetailsViewModels stdView = new StudentDetailsViewModels()
            {
                Std = std,
                Adrs = add,
                Title = "Student Details More Page",
                Header = "Student Complete Details",
            };

            return View(stdView);
        }

    }
}
