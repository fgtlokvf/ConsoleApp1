using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Meat: Product
    {
        private decimal _weight;
        internal decimal Weight { get => _weight; }
        internal Meat(string name, decimal price, decimal weight) : base(name, price)
        {
            _weight = weight;
        }
        public override decimal Price => base.Price * 0.9m; // 10% скидка
        public override string GetInformation() => $"Название: {Name}. Стоимость с учетом 10% скидки: {Price}, Вес: {_weight}";

    }
}
