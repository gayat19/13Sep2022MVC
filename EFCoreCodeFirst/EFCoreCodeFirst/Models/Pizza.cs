using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class Pizza
    {
        [Key]
        public int PID { get; set; }
        [Required]
        public string Name { get; set; }
        public float Price { get; set; }
        public string Pic { get; set; }
        public ICollection<PizzaTopping> PizzaTopping { get; set; }
    }
}
