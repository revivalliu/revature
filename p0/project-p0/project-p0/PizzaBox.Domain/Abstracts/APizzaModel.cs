using System.Collections.Generic;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Abstracts
{ //the principal entity
  public class APizzaModel : AEntity
  {  //public int APizzaModelId { get; set; }
     public Crust Crust{ get; set; }
     public Size Size { get; set; }
     public string Name { get; set; }
     public Order Order { get; set; }
     public List<Topping> _toppings {get; set;}
   
    public void AddTopping(Topping topping)
     {
        _toppings.Add(topping);
     }

    public void AddToppings(List<Topping> toppings)
    {
      _toppings.AddRange(toppings);
    }

    protected APizzaModel(Crust crust, Size size)
    {
      AddCrust(crust);
      AddSize(size);
      AddToppings();
    }
    public APizzaModel()
    {

    }
    public APizzaModel(string name, Size size, Crust crust)
    {       Name = name;
            Size = size;
            Crust = crust;
    }
 
    protected virtual void AddCrust(Crust crust) {}
    protected virtual void AddSize(Size size) { }
    protected virtual void AddToppings() { }
  }
}
    
