using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class Topping : AEntity
  {
    //public int ToppingId { get; set; }  // must be public!

    public decimal Price { get; set; }
    public string Name { get; set; }

   public Topping(string name, decimal price)
    {
      Name = name;
      Price = price;
    }
   public Topping()
    {
      
    }
    public override string ToString()
    {
      return $"{Name} ----- {Price.ToString("C2")}";
    }
  }
}
