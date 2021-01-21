using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;

namespace PizzaBox.Client
{
  public class SqlClient
  {
    public PizzaBoxContext _db = new PizzaBoxContext();

    public IEnumerable<Order> ReadOrders(Store store) // how to make this generic
    {
      var s = ReadOne(store.Name);

      return s.Orders;
    }
    
    
      public Store ReadOne(string name)
    {
      var s = _db.Stores.FirstOrDefault(s => s.Name == name); //linq - predicate
                                                                   // return _db.Stores.SingleOrDefault(s => s.Name == name);

      // int x = 10; // eager loading

      // var stores = from s in _context.Stores // linq - query
      //             where s.Name == name
      //             select s; // lazy loading

      // _context.Stores.Add(new Store(){ Name = name});
      // _context.SaveChanges();

      // return stores.ToList();
      return s;
    }
        
    public IEnumerable<Order> ReadPresets()
    {
      return _db.Orders;
    }

    public IEnumerable<User> ReadUsers()
    {
      return _db.Users;
    }
     public Store SelectStore()
    {
      string input = Console.ReadLine();

      return ReadOne(input);
    }
     public IEnumerable<Store> ReadStores()
    {
      return _db.Stores;
    }
     public IEnumerable<Size> ReadSize()
    {
      return _db.Sizes;
    }
    public IEnumerable<Crust> ReadCrusts()
   {
     return _db.Crusts;
    }
  public void UserOrderHistory(User user)
    {
      var u = _db.Users.Include(u => u.Orders)
                        .ThenInclude(o => o.Pizzas)
                        //.ThenInclude(p => p.Crust)
                        .FirstOrDefault(u => u.EntityId == user.EntityId); // explicit loading
      var o = u.Orders.LastOrDefault();
     // var p = _db.Pizzas.LastOrDefault().Crust;
    }
  
    public void Save(Store store)
    {
      _db.Add(store); // git add
      _db.SaveChanges(); // git commit
    }
    public void Update()
    { _db.SaveChanges();
    }
    public void CreateStore()
    {
      Save(new Store());
    }

     public void RevenueByWeek()
     {     
  }
}
    }
