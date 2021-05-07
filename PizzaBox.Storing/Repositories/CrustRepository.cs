using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }

    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      throw new System.NotImplementedException();
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
  }

}