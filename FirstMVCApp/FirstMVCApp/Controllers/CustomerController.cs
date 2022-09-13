using FirstMVCApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class CustomerController : Controller
    {
        [HttpGet]
        [Route("TotallyNew")]//Attribute based routing
        public IActionResult MyMethod()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult PostIndex()
        {
            return RedirectToAction("Index", "Home");
        }
        [HttpGet]
        public IActionResult Login()
        {
            ViewBag.errmsg = new Error();
            return View();
        }
        [HttpPost]
        public IActionResult Login(IFormCollection form)
        {
            int cid = 0;
            string password = "";
            cid = Convert.ToInt32(form["cid"].ToString());
            password = form["cpass"].ToString();
            if (cid > 100 && password == "1234")
            {
                //return "Welcome " + cid;
                TempData["username"] = cid.ToString();
                return RedirectToAction("Index");
            }
            else
            {
                // return "Invalid username or password";
                Error err = new Error
                {
                    Title = "Login Error",
                    Message = "Invalid username or password"
                };
                //ViewData["errmsg"] = err;
                ViewBag.errmsg = err;

                return View();
            }
               
                
        }
    }
}
