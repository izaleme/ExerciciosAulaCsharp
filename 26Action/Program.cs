using System;
using System.Collections.Generic;
using Action.Entities;

namespace Action
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> list = new List<Product>();

            list.Add(new Product("TV", 900.00));
            list.Add(new Product("Mouse", 50.00));
            list.Add(new Product("Tablet", 350.50));
            list.Add(new Product("HD Case", 80.90));

            //Action<Product> act = UpdatePrice;
            //Action<Product> act = p => { p.Price += p.Price * 0.1; };   // => usando expressão lâmbda
            //list.ForEach(act);

            list.ForEach(UpdatePrice);      // >> fazendo dessa forma não precisa usar o Action<Product>
            foreach (Product p in list)
            {
                Console.WriteLine(p);
            }
        }

        static void UpdatePrice(Product p)
        {
            p.Price += p.Price * 0.1;
        }
    }
}
