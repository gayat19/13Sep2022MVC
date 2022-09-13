using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstMVCApp.Controllers
{
    public class CustController : Controller
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer{Id=101,Name="Tim",Age=21,EMail="tim@gmail.com",Phone="1234567890"},
            new Customer{Id=102,Name="Jim",Age=45,EMail="jim@gmail.com",Phone="9876543210"}
        };
        public IActionResult Index()
        {
            ViewBag.customers = customers;
            ViewBag.Emails = new List<SelectListItem>()
            {
                new SelectListItem{Text="abc@gmail.com", Value="abc"},
                new SelectListItem{Text="xyz@gmail.com", Value="xyz"}
            };
            return View();
        }
        public IActionResult Details(int id)
        {
            ViewBag.Customer = customers.Find(cust => cust.Id == id);
            return View();
        }
        public IActionResult IndexModel()
        {
            return View(customers);
        }
        public IActionResult Create()
        {
            ViewBag.errmsg = new Error();
            return View();
        }
        [HttpPost]
        public IActionResult Create(Customer customer)
        {
            bool check = false;
            foreach (var item in customers)
            {
                if(item.Id==customer.Id)
                {
                    check = true;
                    break;
                }
            }
            if (check)
            {
                ViewBag.errmsg = new Error() { Title = "Duplicate Id", Message = "Id already present" };
                return View(); 
            }
            customers.Add(customer);
            return RedirectToAction("IndexModel");
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.errmsg = new Error();
           Customer customer = customers.Find(cust => cust.Id == id);
            if(customer == null)
                ViewBag.errmsg = new Error() { Title="Not Fount",Message=$"Customer with ID {id} is not present"};
            return View(customer);

        }
        [HttpPost]
        public IActionResult Edit(int id,Customer customer)
        {
            if(ModelState.IsValid)
            {
                Customer myCustomer = customers.Find(cust => cust.Id == id);
                if (customer != null)
                {
                    myCustomer.Name = customer.Name;
                    myCustomer.Age = customer.Age;
                    myCustomer.EMail = customer.EMail;
                    myCustomer.Phone = customer.Phone;
                    return RedirectToAction("IndexModel");
                }
                ViewBag.errmsg = new Error() { Title = "Not Fount", Message = $"Customer with ID {id} is not present" };
                return View();
            }
            ViewBag.errmsg = new Error();
            return View();
        }

    }
}
