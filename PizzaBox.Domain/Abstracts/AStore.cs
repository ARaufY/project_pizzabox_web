
using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public abstract class AStore : AModel
  {
    public string Name { get; set; }

    public List<Order> Orders { get; set; }

    public ICollection<Customer> Customers { get; set; }

    public long OrderEntityId { get; set; }

    public override string ToString()
    {
      return Name;
    }

  }
}