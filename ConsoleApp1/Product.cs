using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal abstract class Product
    {
        private string _name;
        private decimal _price;
        public string Name { get => _name; }
        public virtual decimal Price { get => _price; }
        protected Product(string name, decimal price)
        {
            _name = name;
            _price = price;
        }
        public abstract string GetInformation();
        
    }
}
