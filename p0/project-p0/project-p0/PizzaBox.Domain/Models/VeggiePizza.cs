using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;


namespace PizzaBox.Domain.Models
{
  public class VeggiePizza : APizzaModel
  {
    //private PizzaBoxContext _db = new PizzaBoxContext();
    public List<Topping> _toppings { get; set; }
    public VeggiePizza(){
            Crust c = new Crust ("St. Louis", 4);

            Crust = c;
            Size s = new Size("Large", 10);

            Size = s;
            Name = "VeggiePizza";
    }
    protected override void AddCrust(Crust crust)
    {
      Crust = crust;
    }

    protected override void AddSize(Size size)
    { 
      Size = size;
    }

    protected void AddToppings()
    {
      Topping topping0 = new Topping("tomato", 0);
      _toppings.Add(topping0);
      Topping topping1 = new Topping("cheese", 0);
      _toppings.Add(topping1);

    }
  }
}

