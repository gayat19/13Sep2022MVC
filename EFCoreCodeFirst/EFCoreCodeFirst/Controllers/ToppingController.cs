using EFCoreCodeFirst.Models;
using EFCoreCodeFirst.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Controllers
{
    public class ToppingController : Controller
    {
        private readonly IRepo<int, Topping> _repo;
        private readonly ListPizzaService _service;

        public ToppingController(IRepo<int,Topping> repo,ListPizzaService service)
        {
            _repo = repo;
            _service = service;
        }
        // GET: ToppingController
        public ActionResult Index()
        {
            _service.GetPizzAndToppings();
            return View(_repo.Get());
        }

        // GET: ToppingController/Details/5
        public ActionResult Details(int id)
        {
            var topping = _repo.GetByKey(id);
            return View(topping);
        }

        // GET: ToppingController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ToppingController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Topping topping)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    var top = _repo.Add(topping);
                    if (top != null)
                        return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: ToppingController/Edit/5
        public ActionResult Edit(int id)
        {
            var topping = _repo.GetByKey(id);
            return View(topping);
        }

        // POST: ToppingController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Topping topping)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var top = _repo.Update(id,topping);
                    if (top != null)
                        return RedirectToAction("Index");
                }
            }
            catch
            {
                return View();
            }
            return View();
        }

        // GET: ToppingController/Delete/5
        public ActionResult Delete(int id)
        {
            var topping = _repo.GetByKey(id);
            return View(topping);
        }

        // POST: ToppingController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Topping topping)
        {
            try
            {
                var top = _repo.Delete(id);
                if (top != null)
                    return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
            return View();
        }
    }
}
