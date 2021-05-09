using PizzaBox.Domain.Abstracts;
namespace PizzaBox.Domain.Models
{
  public class SpecialtyPizza : Pizza
  {
    public string Name { get; set; }

    public override string ToString()
    {
      return $"{Name}";
    }
  }
}
