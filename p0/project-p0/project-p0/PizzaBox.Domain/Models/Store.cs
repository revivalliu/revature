using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
/* User User-id[primary key] name
 * Order Order-id[primary], user-id[Foreign key]
 * Pizza Pizza-id[primary], Order-id[foreign key], price, pizza-type, pizza-quantity, crust, size Topping
 * Payment payment-id[primary] user-id[foreign key] pizza-id[foreign key] bill-amount
 * store store-id[primary] user-id[foregin key] order-id[fore]
 */
namespace PizzaBox.Domain.Models
{
  public class Store: AEntity
  {
    //public int StoreId { get; set; }
    public string Name { get; set; }
    public Order Order { get; set; }
    public List<Order> Orders { get; set; }
    
   // public List<Topping> Toppings { get; set; }
   // public List<Size> Sizes { get; set; }
   // public List<Crust> Crusts { get; set; }
    
    //  public List<MeatPizza> store.MeatPizzas { get; set; }
    // public List<VeggiePizza> store.VeggiePizzas { get; set; }


    public Store()
     {
       Orders = new List<Order>();
      }

    public void CreateOrder()
    {
            Order o = new Order();
            o.MakeMeatPizza();
            Orders.Add(o);
     
    }

    public void FulfillOrder()
    {
     }

    //public Pizza CreatePizza(string name, Topping toppings, Order order)
    //   {
    //      return order.CreatePizza(name, toppings);
    //   }
    public override string ToString()
    {
      return $"{Name}";
     }
    
    bool DeleteOrder(Order order)
    {
      try
      {
        Orders.Remove(order);

        return true;
      }
      catch
      {
        return false;
      }
    }
  }
}

