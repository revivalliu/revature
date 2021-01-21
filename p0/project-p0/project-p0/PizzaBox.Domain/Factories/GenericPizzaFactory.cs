using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Models;

namespace PizzaBox.Domain.Factories
{
  class GenericPizzaFactory
  {
    //public T Make<T>() where T : APizzaModel, new()
    public APizzaModel Make<T>() where T : APizzaModel, new()
    {
            if(typeof(T) == typeof(MeatPizza)){
                return new MeatPizza();
            }
            return new T();
    }
  }
}
