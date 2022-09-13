using FirstMVCApp.Models;
using FirstMVCApp.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly SampleService _service;
        private readonly IRepo _repo;

        public HomeController(ILogger<HomeController> logger,SampleService service,IRepo repo)
        {
            _logger = logger;
            _service = service;
            _repo = repo;
        }
        [LogCallActionFilter]
        public IActionResult Index()
        {
            _logger.LogInformation("In the index method");
            return View();
        }
        public List<string> Check()
        {
            return _repo.Get();
        }
        public string AddName(string name)
        {
            _repo.Add(name);
            return name;
        }
        public IActionResult CheckView()
        {
            Sample sample = new Sample() { 
                Id=101,Name="Jim"
            };
            
            return View(sample);
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [ActionName("ViewName")]//Action method's name
        public IActionResult ChangedName()//Methodname
        {
            return View();
        }
    }
}
