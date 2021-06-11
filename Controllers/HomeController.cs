using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//Link to Swagger: https://localhost:44312/swagger/index.html

namespace Covid_App_2._0.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("GetAllLogs")]
        public IActionResult GetAll()
        {
            return Ok("This is GETAll");
        }

        [HttpGet]
        [Route("GetLogsByUserId")]
        public IActionResult GetUserLogs([FromQuery] string Email)
        {
            return Ok("This is GET Email: "+Email);
        }
        [HttpPost]
        [Route("PostNewLog")]
        public IActionResult Post([FromQuery] string Email) 
        {
            return Ok("This is POST Email: "+Email);
        }
        [HttpPut]
        [Route("UpdateLog")]
        public IActionResult Update([FromQuery] string Email)
        {
            return Ok("This is Update");
        }
        [HttpDelete]
        [Route("DeleteLog")]
        public IActionResult DeleteLog([FromQuery] int ID)
        {
            return Ok("This is Delete");
        }

    }
}
