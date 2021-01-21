using System.Collections.Generic;
using System.Linq;
using PizzaBox.Domain.Abstracts;

namespace PizzaBox.Storing
{
  public class PizzaBoxRepository
  {
    private PizzaBoxContext _ctx;

    public PizzaBoxRepository(PizzaBoxContext context)
    {
      _ctx = context;
    }

    public List<string> GetStores()
    {
      return _ctx.Stores.Select(s => s.Name).ToList();
    }

    public List<string> GetOrders()
    {
      return _ctx.Orders.Select(o => o.ToString()).ToList();
    }
    public List<string> GetCustomers()
    {
      return _ctx.Customers.Select(c => c.Name).ToList();
    }

    public void Save()
    {
      //_ctx.Add(store); // git add
      _ctx.SaveChanges(); // git commit
    }
    // public IEnumerable<T> Get<T>() where T : AModel
    // {
    //   return _ctx.Set<T>().Select(t => t.GetType().GetProperty()).ToList();
    // }
  }
}
