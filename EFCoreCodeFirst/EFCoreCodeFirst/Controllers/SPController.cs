using EFCoreCodeFirst.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Controllers
{
    public class SPController : Controller
    {
        private ListPizzaService _service;

        public SPController(ListPizzaService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View(_service.GetPizzAndToppings());
        }
    }
}
