using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.Models
{
    public class PizzaStoreContext : DbContext
    {

        public PizzaStoreContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Topping> Toppings { get; set; }
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<PizzaTopping> PizzaToppings { get; set; }
        public DbSet<VMPizzaToping> vMPizzaTopings { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PizzaTopping>().HasKey(pt => new {
                pt.PizzaId,pt.ToppingId
            }).HasName("PK_PizzaToppingKey");

        }
    }
}
