using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Drinks : Product
    {
        private bool _alc;
        internal bool Alc { get => _alc; }
        internal Drinks(string name, decimal price, bool alc) : base(name, price)
        {
            _alc = alc;
        }
        public override decimal Price => base.Price * 0.85m; // 15% скидка
        public override string GetInformation() => $"Название: {Name}. Стоимость с учетом 15% скидки: {Price}, Алкоголь: {_alc}";
        
    }
}
