using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Order : AModel
  {
    public List<Pizza> Pizzas { get; set; }
    public Customer Customer { get; set; }
  }
}