using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {
            return Json(new { name = "Dedi", Departement ="SE", Salary = "Rp.25.000.000" }); ;
        }
    }
}
