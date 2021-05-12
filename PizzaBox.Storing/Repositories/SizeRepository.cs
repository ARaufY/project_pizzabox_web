using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class SizeRepository : IRepository<Size>
  {
    private readonly PizzaBoxContext _context;

    public SizeRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete(Size entry)
    {
      try
      {
        _context.Sizes.Remove(entry);
        return true;
      }
      catch
      {
        System.Console.WriteLine("Unable to delete size");
      }


      return false;
    }

    public bool Insert(Size entry)
    {
      _context.Sizes.Add(entry);
      return true;
    }

    public IEnumerable<Size> Select(Func<Size, bool> filter)
    {
      return _context.Sizes.Where(filter);
    }

    public Size Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
