using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HelloWorld.Models;
using HelloWorld.Data_Access;
using HelloWorld.Data_Access.Interface;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public string StartPage()
        {
            return "StartPage() Action Method of StudentController";
        }
        public ViewResult Details()
        {
            ViewData["Title"] = "Student Details Page";
            ViewData["Header"] = "Student Details";

            Student std = new Student()
            {
                StudentId = 101,
                Name = "James",
                Branch = "CSE",
                Section = "A",
                Gender = "Male"
            };

            //ViewData["Student"] = std;

            return View(std);

        }

        //Create a reference variable of IStudentRepository
        private readonly IStudentRepository _repository = null;

        //Initialize the variable through constructor
        public HomeController(IStudentRepository repository)
        {
            _repository = repository;
        }
        public ViewResult GetStudentDetails(int Id)
        {
            //Use the _repository to call the GetStudentById method 
            Student studentDetails = _repository.GetStudentById(Id);
            return View(studentDetails);
        }
        
        [Route("Home/Details/{id?}")]
        public string Details(int id)
        {
            return "Details() Action Method of HomeController, ID Value = " + id;
        }
    }
}
