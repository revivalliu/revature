using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.Extensions.Configuration;
using PizzaBox.Storing;

//using Microsoft.Extensions.Configuration;

namespace PizzaBox.WebClient.Models
{
  public class StoreViewModel
  {
    public List<string> Stores { get; set; }
    public List <OrderViewModel> Orders { get; set; }
    public string Name;

    public StoreViewModel()
    {
      Stores = new List<string>()
      { "PizzaHut",
        "Domino",
        "RoundTable"
      };

      //Order = new OrderViewModel();
      System.Console.WriteLine("443434343 ,,,, Standard Numeric Format Specifiers....");
    }

    public void StoreViewModelWithName(string name)
    {
      Name = name;
      //Order = new OrderViewModel();
    }
  }
}
