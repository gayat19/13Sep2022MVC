using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class VMPizzaToping
    {
        public int Id { get; set; }
        public string PizzaName { get; set; }
        public string ToppingName { get; set; }
        public float PizzaPrice { get; set; }
        public float ToppingPrice { get; set; }
    }
}
