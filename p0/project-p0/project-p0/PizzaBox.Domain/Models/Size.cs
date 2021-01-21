using System.Collections.Generic;
using PizzaBox.Domain.Abstracts;
using PizzaBox.Domain.Factories;

namespace PizzaBox.Domain.Models

{
    public class Size: AEntity
    {
        //public int SizeId { get; set; }  // must be public!
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Size() { }

        public Size(string name, decimal price)
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
