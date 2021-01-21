using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models
{
    public class Crust : AEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int CrustId { get; set; }

        public Crust() { }

        public Crust(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Name} - {Price.ToString("C2")}";
        }
    }
}

