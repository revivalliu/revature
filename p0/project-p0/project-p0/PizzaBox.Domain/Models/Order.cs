using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;
using System.Linq;

namespace PizzaBox.Domain.Models
{
 public class Order : AEntity
    {
    public System.DateTime DateOrdered { get; set; }
    public decimal Price { get; set; }
    public APizzaModel Pizza { get; set; }
    public User User { get; set; }
    public Store Store { get; set; }

    public List<APizzaModel> Pizzas { get; set; }
    private GenericPizzaFactory _pizzaFactory = new GenericPizzaFactory();
   // public int OrderId { get; set; }
   
    public Order()
    {
      Pizzas = new List<APizzaModel>();
      //DateOrdered = System.DateTime.UtcNow;
    }
    public Order(User u, decimal p, Store s)
    {
            //DateOrdered = dt;
            DateOrdered = System.DateTime.UtcNow;
            Price = p;
            //user = u;
            //store.EntityId= s.EntityId;
            
            Pizzas = new List<APizzaModel>();
    }
    public Order(string MEAT)
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
    }

    public void MakeMeatPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<MeatPizza>());
      //System.Console.WriteLine($"\nOrdering xxxxx");
    }

     public void MakeVeggiePizza()
    {
      Pizzas.Add(_pizzaFactory.Make<VeggiePizza>());
    }
    public void MakeCustomPizza()
    {
      Pizzas.Add(_pizzaFactory.Make<APizzaModel>());
      //System.Console.WriteLine($"\nOrdering xxxxx");
    }
   /*  public decimal PizzaPrice()
     {
          return Pizzas.Sum(Pizza => Pizza.PizzaPrice());
     }
   */
  }
 
}

