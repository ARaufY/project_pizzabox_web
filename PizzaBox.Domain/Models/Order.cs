using System;
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : AModel
  {
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
    public Store Store { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal Cost
    {
      get
      {
        decimal cost = 0m;
        foreach (var pizza in Pizzas)
        {
          var toppingCost = 0.0m;
          foreach (var t in pizza.Toppings)
          {
            toppingCost += t.Price;
          }
          cost = cost + pizza.Crust.Price + pizza.Size.Price + toppingCost;
        }
        return cost;
      }
    }


  }
}