using EFCoreCodeFirst.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Services
{
    public class ToppingRepo : IRepo<int, Topping>
    {
        private readonly PizzaStoreContext _context;
        private readonly ILogger<ToppingRepo> _logger;

        public ToppingRepo(PizzaStoreContext context,ILogger<ToppingRepo> logger)
        {
            _context = context;
            _logger = logger;
        }
        public Topping Add(Topping item)
        {
            try
            {
                _logger.LogInformation(_context.Entry(item).State.ToString());
                _context.Toppings.Add(item);
                _logger.LogInformation(_context.Entry(item).State.ToString());
                _context.SaveChanges();
                _logger.LogInformation(_context.Entry(item).State.ToString());
                return item;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
            }
            return null;
        }

        public Topping Delete(int key)
        {
            Topping topping = GetByKey(key);
            if (topping == null)
                return null;
            _context.Toppings.Remove(topping);
            _context.SaveChanges();
            return topping;
        }

        public IEnumerable<Topping> Get()
        {
            List<Topping> toppings = _context.Toppings.ToList();
            if (toppings.Count == 0)
                return null;
            return toppings;
        }

        public Topping GetByKey(int key)
        {
            Topping topping = _context.Toppings.FirstOrDefault(top => top.Id == key);
            return topping;
        }

        public Topping Update(int key, Topping Item)
        {
            Topping topping = GetByKey(key);
            if (topping == null)
                return null;
            topping.Name = Item.Name;
            topping.Price = Item.Price;
            _context.SaveChanges();
            return topping;
        }
    }
}
