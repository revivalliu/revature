using System.Collections.Generic;
using System.Linq;
using System.Text;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Domain.Models
{
  public class User : AEntity
  {
    public string Name { get; set; }
    public Store SelectedStore { get; set; }
    public Order Order { get; set; }
    public ICollection<Order> Orders { get; set; }
    
    public User()
    {
      Orders = new List<Order>();
      
    }

    public User(string name)
    {
            Name = name;
            Orders = new List<Order>();
      
    }
        /*
    public User(string name, Store selectedStore, )
    {
            Name = name;
            Orders = new List<Order>();
      
    }*/

    public override string ToString()
    {
      var sb = new StringBuilder();
      //string s = "";

      foreach (var p in Orders.Last().Pizzas)
      {
        sb.AppendLine(p.ToString());
        //s.Concat(p.ToString());
      }

      return $"you have selected this store: {SelectedStore} and ordered these pizzas: {sb.ToString()}"; // string interpolation
      //return "I have selected this store: " + SelectedStore.ToString(); // string concatenation
    }
  }
}
