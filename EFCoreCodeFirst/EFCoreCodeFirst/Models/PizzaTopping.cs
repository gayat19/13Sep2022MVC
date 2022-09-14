using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class PizzaTopping
    {
        public int PizzaId { get; set; }
        public int ToppingId { get; set; }
        [ForeignKey("PizzaId")]
        public Pizza Pizza { get; set; }
        [ForeignKey("ToppingId")]
        public Topping Topping { get; set; }
    }
}
