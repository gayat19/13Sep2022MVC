using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Topping
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }

        public ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
