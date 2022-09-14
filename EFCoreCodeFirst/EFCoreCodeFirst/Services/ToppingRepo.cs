using EFCoreCodeFirst.Models;
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

        public ToppingRepo(PizzaStoreContext context)
        {
            _context = context;
        }
        public Topping Add(Topping item)
        {
            try
            {
                Debug.WriteLine(_context.Entry(item).State);
                _context.Toppings.Add(item);
                Debug.WriteLine(_context.Entry(item).State);
                _context.SaveChanges();
                Debug.WriteLine(_context.Entry(item).State);
                return item;
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
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
