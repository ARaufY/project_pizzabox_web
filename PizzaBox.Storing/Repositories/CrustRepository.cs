using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CrustRepository : IRepository<Crust>
  {
    private readonly PizzaBoxContext _context;

    public CrustRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete(Crust entry)
    {
      _context.Crusts.Remove(entry);
      return true;
    }

    public bool Insert(Crust entry)
    {
      _context.Crusts.Add(entry);
      return true;
    }

    public IEnumerable<Crust> Select(Func<Crust, bool> filter)
    {
      return _context.Crusts.Where(filter);
    }

    public Crust Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
