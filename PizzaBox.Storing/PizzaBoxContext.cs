using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage
{
  public class PizzaBoxContext : DbContext
  {
    public DbSet<Crust> Crusts { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Pizza> Pizzas { get; set; }
    public DbSet<Size> Sizes { get; set; }
    public DbSet<Topping> Toppings { get; set; }

    public DbSet<Customer> Customers { get; set; }
    public DbSet<Store> Stores { get; set; }

    public DbSet<SpecialtyPizza> SpecialcialtyPizza { get; set; }

    public PizzaBoxContext(DbContextOptions options) : base(options) { }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="builder"></param>
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasKey(e => e.EntityId);
      builder.Entity<Order>().HasKey(e => e.EntityId);
      builder.Entity<Pizza>().HasKey(e => e.EntityId);
      builder.Entity<Size>().HasKey(e => e.EntityId);
      builder.Entity<Topping>().HasKey(e => e.EntityId);
      builder.Entity<Customer>().HasKey(e => e.EntityId);
      builder.Entity<Store>().HasKey(e => e.EntityId);
      //builder.Entity<SpecialtyPizza>().HasKey(e => e.EntityId);
      builder.Entity<SpecialtyPizza>().HasBaseType<Pizza>();

      OnModelSeeding(builder);
    }

    private void OnModelSeeding(ModelBuilder builder)
    {
      builder.Entity<Crust>().HasData(new[]
      {
        new Crust() { EntityId = 1, Name = "original" },
        new Crust() { EntityId = 2, Name = "stuffed" },
        new Crust() { EntityId = 3, Name = "flatbread" },
        new Crust() { EntityId = 4, Name = "thin" },
      });

      builder.Entity<Size>().HasData(new[]
      {
        new Size() { EntityId = 1, Name = "small", Price = 2.0m },
        new Size() { EntityId = 2, Name = "medium", Price = 3.0m },
        new Size() { EntityId = 3, Name = "large", Price = 5.0m}
      });

      builder.Entity<Topping>().HasData(new[]
      {
        new Topping() { EntityId = 1, Name = "pepperoni", Price = 2.0m},
        new Topping() { EntityId = 2, Name = "pineapple", Price = 2.0m },
        new Topping() { EntityId = 3, Name = "ham", Price = 2.0m },
        new Topping() { EntityId = 4, Name = "green peppers", Price = 2.0m },
        new Topping() { EntityId = 5, Name = "black olives", Price = 2.0m }
      });

      builder.Entity<Customer>().HasData(new[]
      {
        new Customer(){EntityId = 1, Name = "Bruce Wyane"},
        new Customer(){EntityId = 2, Name = "Clark Kent"}
      });

      // builder.Entity<SpecialtyPizza>().HasData(new[]
      // {
      //   new SpecialtyPizza(){EntityId = 1, Name = "Veggie Pizza",}
      // });
    }
  }
}
