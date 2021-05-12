using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class StoreRepository : IRepository<Store>
  {
    private readonly PizzaBoxContext _context;

    public StoreRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete(Store entry)
    {
      _context.Stores.Remove(entry);
      return true;
    }

    public bool Insert(Store entry)
    {
      _context.Stores.Add(entry);
      return true;
    }

    public IEnumerable<Store> Select(Func<Store, bool> filter)
    {
      return _context.Stores.Where(filter);
    }

    public Store Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
