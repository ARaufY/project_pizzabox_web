using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class OrderRepository : IRepository<Order>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Order> Select(Func<Order, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Order Update()
    { 
      throw new System.NotImplementedException();
    }
  }

}