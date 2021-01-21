using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.Extensions.Configuration;
using PizzaBox.Storing;
using System.Linq;


namespace PizzaBox.WebClient.Models
{
  public class OrderViewModel
  {
    private readonly IConfiguration _configuration;
    private PizzaBoxContext _ctx;
    public List<string> Stores { get; set; }
    public string Store { get; set; }

    public List<PizzaViewModel> Pizzas { get; set; }

    public List<PizzaViewModel> PizzaSelection { get; set; }


    public CustomerViewModel User { get; set; }

    public OrderViewModel(IConfiguration configuration)
    {
       _ctx = new PizzaBoxContext(configuration);
       Stores = _ctx.Stores.Select(s => s.Name).ToList();
       
    }
    public OrderViewModel()
    {
       
    }

    public OrderViewModel(string id)
    { ///id not used??? get orderby id?
       Pizzas = new List<PizzaViewModel>();
         
       Stores = new List<string>();
          
       PizzaSelection = new List<PizzaViewModel>();
    }
    /* public List<string> Stores ------
     * { 
     *    get
     *     {
     *        return PizzaBoxReposity.GetStores();
     *     }
     * }
     */

  }
  }
