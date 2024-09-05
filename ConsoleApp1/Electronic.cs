using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Electronic : Product
    {
        private int _year;
        internal int Year { get => _year; }
        internal Electronic(string name, decimal price, int year) : base(name, price)
        {
            _year = year;
        }
        public override decimal Price => base.Price * 0.5m; // 50% скидка
        public override string GetInformation() => $"Название: {Name}. Стоимость с учетом 20% скидки: {Price}, Год выпуска: {_year}";
    }
}
