using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class UserController : Controller
    {
        [Route("allow")]
        [Route("[controller]/[action]")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("[controller]/[action]/{username}")]
        public IActionResult Index(string username)
        {
            ViewBag.username = username;
            return View();
        }
    }
}
