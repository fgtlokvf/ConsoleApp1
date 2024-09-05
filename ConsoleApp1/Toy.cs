using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Toy : Product
    {
        private int _age;
        internal int Age { get => _age; }
        internal Toy(string name, decimal price, int age): base(name, price)
        {
            _age = age;
        }
        public override decimal Price => base.Price * 0.8m; // 20% скидка
        public override string GetInformation() => $"Название: {Name}. Стоимость с учетом 20% скидки: {Price}, Рекоменд. возраст: {_age}";
    }
}
