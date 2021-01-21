using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaBox.Domain.Models;
using PizzaBox.Storing;
using PizzaBox.WebClient.Models;

namespace PizzaBox.WebClient.Controllers
{
  [Route("[controller]")]
  public class OrderController : Controller
  {
    private readonly PizzaBoxContext _ctx;

    public OrderController(IConfiguration configuration){
             _ctx = new PizzaBoxContext(configuration);
        }}}
 /*   [HttpGet]
    public IActionResult Get()
    {
        return View("Order");
     }

    [HttpGet("{id}")]

    public IActionResult Get(string id)
    {
        return View("Order", new OrderViewModel(id));
    }[HttpPost]
 */
    

 /*   public IActionResult Post(OrderViewModel model)
    {
        if (ModelState.IsValid)
        {
             var order = new Order()
             {
             DateModified = DateTime.Now;
             Store = _ctx.Orders.Add(new Order() {Store = _ctx.Stores.FirstOrDefault(s=>s.Name ==model.Store)});
        }
        _ctx.Orders.Add(order);
        return View("home", model);

    }
 */
    ///new ....
 /*   public IActionResult PlaceOrder(
         [Bind("store,pizza,name,city,state")] OrderViewModel o)
     {
            try
    {
        if (ModelState.IsValid)
        {
            //_ctx.GetStores
            //_ctx.Orders.Add(o);
            _ctx.Save();

            return RedirectToAction(nameof(Index));
        }
    }

    {

    }
    
    return View("home", o);
   }
    ///
    ///


  }
}
    /*private readonly PizzaBoxContext _ctx;
    public OrderController(PizzaBoxContext context)
    {
      _ctx = context;
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Post(OrderViewModel model)
    {
      //Console.WriteLine("Standard Numeric Format Specifiers");
      if (ModelState.IsValid)
      {
        var order = new Order()
        {
          DateModified = DateTime.Now,
          Store = _ctx.Stores.FirstOrDefault(s => s.Name == model.Store)
        };

        _ctx.Orders.Add(order);
        _ctx.SaveChanges();

        return View("OrderPlaced");
      }

      return View("home", model);
    }
  }
}
    */
