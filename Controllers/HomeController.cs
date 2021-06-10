using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_App_2._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Ok("This is working");
        }
    }
}
