using System;
using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Interfaces;
using PizzaBox.Domain.Models;

namespace PizzaBox.Storage.Repositories
{
  public class CustomerRepository : IRepository<Customer>
  {
    private readonly PizzaBoxContext _context;

    public CustomerRepository(PizzaBoxContext context)
    {
      _context = context;
    }

    public bool Delete(Customer entry)
    {
      _context.Customers.Remove(entry);
      return true;
    }

    public bool Insert(Customer entry)
    {
      _context.Customers.Add(entry);
      return true;
    }

    public IEnumerable<Customer> Select(Func<Customer, bool> filter)
    {
      return _context.Customers.Where(filter);
    }

    public Customer Update()
    {
      throw new System.NotImplementedException();
    }
  }
}
