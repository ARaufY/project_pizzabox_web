using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class PizzaRepository : IRepository<Pizza>
  {
    private readonly PizzaBoxContext _context;

    public PizzaRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete(Pizza entry)
    {
      _context.Pizzas.Remove(entry);
      return true;
    }

    public bool Insert(Pizza entry)
    {
      _context.Pizzas.Add(entry);
      return true;
    }

    public IEnumerable<Pizza> Select(Func<Pizza, bool> filter)
    {
      return _context.Pizzas.Where(filter);
    }

    public Pizza Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
