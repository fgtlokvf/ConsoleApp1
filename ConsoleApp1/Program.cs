using ConsoleApp1;
using System;

class Program
{
    static void Main()
    {
        CustomConverter c = new CustomConverter();
        
        c.Convert("123", out int a);
        c.Convert("123.45", out double b);
        c.Convert("false", out bool s);
        Console.WriteLine(a.GetType());
        Console.WriteLine(b.GetType());
        Console.WriteLine(s.GetType());

        Toy toy1 = new("Игрушка№1", 99.9m, 3);
        Toy toy2 = new("Игрушка№2", 100, 5);
        Toy toy3 = new("Игрушка№3", 200, 7);
        Drinks drink1 = new("pepsa", 100, false);
        Drinks drink2 = new("viski", 125, true);
        Meat meat1 = new("govyadina", 111.1m, 0.5m);
        Electronic electronic1 = new("phone", 15999.9m, 2024);
        Product[] products = { toy1, toy2, toy3, drink1,drink2,meat1, electronic1};
        foreach(Product product in products)
        {
            Console.WriteLine(product.GetInformation());
            Console.WriteLine();
        }
    }
}
