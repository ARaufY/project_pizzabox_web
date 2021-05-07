using System;
using System.Collections.Generic;

namespace PizzaBox.Domain.Interfaces
{
  public interface IRepository<T> where T : class
  {
    public bool Insert();
    public IEnumerable<T> Select(Func<T, bool> filter);
    public T Update();

    public bool Delete();


  }
}