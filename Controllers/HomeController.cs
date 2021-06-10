using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_App_2._0.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult GetAll()
        {
            return Ok("This is GETAll");
        }
        
        public IActionResult GetUser([FromQuery] string Email)
        {
            return Ok("This is GET Email: "+Email);
        }
        public IActionResult Post([FromQuery] string Email) 
        {
            return Ok("This is POST Email: "+Email);
        }
        public IActionResult Update([FromQuery] string Email)
        {
            return Ok("This is Update");
        }
        public IActionResult DeleteLog([FromQuery] int ID)
        {
            return Ok("This is Delete");
        }

    }
}
