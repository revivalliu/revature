using System.Collections.Generic;

namespace PizzaBox.WebClient.Models
{
  public class PizzaViewModel
  {
      public string Crust { get; set;}

      public string Size { get; set; }

      public List<string> Toppings { get; set; }

      public decimal Price { get; set; }
    }
}
