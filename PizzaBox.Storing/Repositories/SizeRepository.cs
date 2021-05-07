using System;
using System.Collections.Generic;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    public bool Delete()
    {
      throw new System.NotImplementedException();
    }

    public bool Insert()
    {
      throw new System.NotImplementedException();
    }


    public Size Update()
    {
      throw new System.NotImplementedException();
    }

    IEnumerable<Size> IRepository<Size>.Select(Func<Size, bool> filter)
    {
      throw new NotImplementedException();
    }

    Size IRepository<Size>.Update()
    {
      throw new NotImplementedException();
    }
  }

}