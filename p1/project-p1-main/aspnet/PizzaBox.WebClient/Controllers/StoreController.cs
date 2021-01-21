using Microsoft.AspNetCore.Mvc;
using PizzaBox.WebClient.Models;
using PizzaBox.Storing;

using System.Linq;
//using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

//using PizzaBox.WebClient.Models;

namespace PizzaBox.WebClient.Controllers
{
  [Route("controller")]
  public class StoreController : Controller
  {
    [HttpGet]
    public IActionResult Get()
    {
      var stores = new StoreViewModel();

      ViewBag.Stores = stores.Stores;
      ViewData["Stores"] = stores.Stores;
      TempData["Stores"] = stores.Stores;
      return View("Store");
    }

    [HttpGet("{store}")]
    public IActionResult Get(string store)
    {
      return View("Store", store);
    }
    

    [HttpGet]
    public IActionResult Home()
    {
      string store = "PizzaHut";
      return View("home", store);
    }
  }
}


/*
namespace PizzaBox.WebClient.Controllers
{
  [Route("/[controller]/{action=Home}")]
  public class StoreController : Controller
  {
    // private readonly PizzaStoreDbContext _db;
  //  private StoreViewModel storeViewModel;
    private CustomerViewModel customerViewModel;

    public StoreController(PizzaBoxContext dbContext)
    {
      storeViewModel = new StoreViewModel(dbContext);
      customerViewModel = new CustomerViewModel(dbContext);
    }

    [HttpGet]
    public IActionResult Home()
    {
      if (TempData.Peek("StoreLoggedIn") == null)
      {
        return View("Login", new StoreViewModel());
      }
      return View(new StoreViewModel() { Name = TempData.Peek("StoreLoggedIn").ToString() });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Login(StoreViewModel store)
    {
      if (storeViewModel.Login(store.Name) is null)
      {
        store.Name = null;
      }

      ModelState.Remove("StoreSelected");
      if (ModelState.IsValid)
      {
        TempData["StoreLoggedIn"] = store.Name;
        TempData.Keep("StoreLoggedIn");
        return Redirect("/Store");
      }
      return View();
    }

    [HttpGet]
    public IActionResult NewStore()
    {
      return View("CreateStore", new StoreViewModel());
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult CreateStore(StoreViewModel store)
    {
      ModelState.Remove("StoreSelected");
      if (ModelState.IsValid)
      {
        var newStore = storeViewModel.CreateStore(store.Name);

        if (newStore != null)
        {
          TempData["StoreLoggedIn"] = store.Name;
          TempData.Keep("StoreLoggedIn");
          return Redirect("/Store");
        }
      }
      return View(store);
    }

    public IActionResult Logout()
    {
      TempData.Clear();
      return Redirect("/");
    }

    [HttpGet]
    public IActionResult OrderHistory()
    {
      return View(storeViewModel.OrderHistory(TempData.Peek("StoreLoggedIn").ToString()));
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult OrderHistory(CustomerViewModel customer)
    {
      ModelState.Remove("Name");
      if (ModelState.IsValid)
      {
        return View(storeViewModel.OrderHistory(TempData.Peek("StoreLoggedIn").ToString(), customer.UserSelected));
      }
      return View("UserSelector", customerViewModel);
    }

    [HttpGet]
    public IActionResult OrderHistoryByUser()
    {
      return View("UserSelector", CustomerViewModel);
    }
  }
}

*/
