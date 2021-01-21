using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using PizzaBox.Storing;
using PizzaBox.WebClient.Models;


namespace PizzaBox.WebClient.Controllers
{
  public class CustomerController : Controller
  {
    private readonly IConfiguration _configuration;
    public CustomerController(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    [HttpGet]
    public IActionResult Home()
    {
      /*  var customer = new CustomerViewModel(); --Tuesday aftertoon at 2:31

        customer.Order = new OrderViewModel()
           {
             Orders = _ctx.Orders
           } */
        return View("home", new CustomerViewModel(_configuration));
    }
    [HttpGet]
    public IActionResult Success()
    {
      return View("Success");
    }
  }
}
