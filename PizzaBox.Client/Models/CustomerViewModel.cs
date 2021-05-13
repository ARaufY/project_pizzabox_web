
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using PizzaBox.Domain.Models;
using PizzaBox.Storage;

namespace PizzaBox.Client.Models
{
  public class CustomerViewModel
  {

    public List<Customer> Customers { get; set; }

    public List<Order> Orders { get; set; }
    public List<Store> Stores { get; set; }

    [Required(ErrorMessage = "please select a customer")]
    [DataType(DataType.Text)]
    public Customer SelectedCustomer { get; set; }


    [Required(ErrorMessage = "please select a customer")]
    [DataType(DataType.Text)]
    public Customer SelectedStore { get; set; }


    public void Load(UnitOfWork unitOfWork)
    {
      Customers = unitOfWork.Customers.Select(c => !string.IsNullOrWhiteSpace(c.Name)).ToList();
      Stores = unitOfWork.Stores.Select(s => !string.IsNullOrWhiteSpace(s.Name)).ToList();
    }
  }
}