using Covid_App_2._0.Data;
using Covid_App_2._0.Models;
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
        private readonly CovidLogsContext _db;

        public HomeController(CovidLogsContext db)
        {
            _db = db;
        }

        [HttpGet]
        [Route("AllLogs")]
        public IActionResult GetAlllogs()
        {
            IEnumerable<CovidLogs> objList= _db.Logs;
            return Ok(objList);
        }

        [HttpGet]
        [Route("LogsByUserId")]
        public IActionResult GetUserLogs([FromQuery] string Email)
        {
            IEnumerable<CovidLogs> objList;
            return Ok("Testing");
        }
        [HttpPost]
        [Route("NewLog")]
        public IActionResult PostLog([FromQuery] string Email) 
        {
            return Ok("This is POST Email: "+Email);
        }
        [HttpPut]
        [Route("UpdateLog")]
        public IActionResult UpdateLog([FromQuery] string Email)
        {
            return Ok("This is Update");
        }
        [HttpDelete]
        [Route("DeleteLog")]
        public IActionResult DeleteLog([FromQuery] int ID)
        {
            return Ok("This is Delete");
        }
        //User DB Section

        [HttpPost]
        [Route("createUser")]
        public IActionResult CreateUser([FromQuery] string Email)
        {
            return Ok("create a user: " + Email);
        }

        [HttpPut]
        [Route("editUser")]
        public IActionResult EditUser([FromQuery] string Email)
        {
            return Ok("Edit a user: " + Email);
        }


    }
}
