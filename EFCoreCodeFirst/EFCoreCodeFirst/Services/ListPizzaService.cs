using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Services
{
    public class ListPizzaService
    {
        private readonly PizzaStoreContext _context;

        public ListPizzaService(PizzaStoreContext context)
        {
            _context = context;
        }
        public List<VMPizzaToping> GetPizzAndToppings()
        {
            var data = _context.vMPizzaTopings.FromSqlRaw("exec proc_SelectPizzaNames").AsNoTracking().ToList();
            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.PizzaName+" "+item.ToppingName);
            //}
            return data;
        }
    }
}
