using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class CustomConverter
    {
        public bool Convert(string input, out int res)
        {
            return int.TryParse(input, out res);
        }

        public bool Convert(string input, out double res)
        {
            return double.TryParse(input, out res);
        }

        public bool Convert(string input, out bool res)
        {
            return bool.TryParse(input, out res);
        }
    }
}
