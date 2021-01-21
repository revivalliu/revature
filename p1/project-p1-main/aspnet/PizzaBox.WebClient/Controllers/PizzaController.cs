using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
//using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using PizzaBox.WebClient.Models;

namespace PizzaBox.WebClient.Controllers
{
    [Route("[controller]")]
    public class PizzaController : Controller
    {
        [HttpGet]
        public IEnumerable<PizzaViewModel> List()
        {
            return new List<PizzaViewModel>()
            {
                new PizzaViewModel() { Crust = "regular", Size = "medium", Price = 10 }

             };
        }
    //public void Get() { }
    }
}
