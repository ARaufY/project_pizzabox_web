using Microsoft.AspNetCore.Mvc;
using PizzaBox.Client.Models;

namespace PizzaBox.Client.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    public string Blah(OrderViewModel order)
    {
      if (ModelState.IsValid)
      {
        return order.SelectedCrust;
      }

      return "Invalid input";

    }
  }

}