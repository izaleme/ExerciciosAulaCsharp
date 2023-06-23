using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqLambda.Entities;

namespace LinqLambda
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> collection)
        {
            Console.WriteLine(message);
            foreach (T obj in collection)
            {
                Console.WriteLine(obj);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Electronics", Tier = 1 };

            List<Product> products = new List<Product>()
            {
                new Product(){ Id = 1, Name = "Computer", Price = 1100.0, Category = c2 },
                new Product(){ Id = 2, Name = "Hammer", Price = 90.0, Category = c1 },
                new Product(){ Id = 3, Name = "TV", Price = 1700.0, Category = c3 },
                new Product(){ Id = 4, Name = "Notebook", Price = 1300.0, Category = c2 },
                new Product(){ Id = 5, Name = "Saw", Price = 80.0, Category = c1 },
                new Product(){ Id = 6, Name = "Tablet", Price = 700.0, Category = c2 },
                new Product(){ Id = 7, Name = "Camera", Price = 700.0, Category = c3 },
                new Product(){ Id = 8, Name = "Printer", Price = 350.0, Category = c3 },
                new Product(){ Id = 9, Name = "MacBook", Price = 1800.0, Category = c2 },
                new Product(){ Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3 },
                new Product(){ Id = 11, Name = "Level", Price = 70.0, Category = c1 }
            };

            var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900);    // Pega os produtos tier 1 e com preço < 900
            Print("Products tier 1 and price < 900: ", r1);

            var r2 = products
                .Where(p => p.Category.Name == "Tools")     // Pega somente os produtos que da categoria Tools
                .Select(p => p.Name);                       // Pega um produto p e o transforma apenas no p.Name
            Print("Names of products from tools", r2);

            var r3 = products
                .Where(p => p.Name[0] == 'C')               // Pega somente os produtos começados com C
                .Select(p => new { p.Name, p.Price,         // Pega somente os campos nome, preço, e o nome da categoria
                    CategoryName = p.Category.Name });      // Aqui estamos dando um apelido para o p.Category.Name, para não ter ambiguidade de nomes (já exite o p.Name)
            Print("Names started with 'C' and anonymous object", r3);

            var r4 = products.Where(p => p.Category.Tier == 1)  // Pega os produtos de categoria 1
                .OrderBy(p => p.Price)                          // Ordena pelo preço
                .ThenBy(p => p.Name);                           // Depois ordena pelo nome
            Print("Tier 1 order by price then by name", r4);

            var r5 = r4.Skip(2).Take(4);    // Pula os 2 primeiros elementos, e a seguir pega 4 elementos
            Print("Tier 1 order by price then by name skip 2 take 4", r5);

            var r6 = products.First();      // Pega o primeiro elemento do data source
            Console.WriteLine("First, test 1: " + r6);

            //var r7 = products.Where(p => p.Price > 3000.0).First();       // Não há elementos, portanto vai dar exception
            var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();     // Pega o primeiro ou trás vazio
            Console.WriteLine("First, test 2: " + r7);

            var r8 = products.Where(p => p.Id == 3).SingleOrDefault();      // Trás apenas um elemento, e se não tiver, trás vazio
            Console.WriteLine("Single or default, test 1: " + r8);

            var r9 = products.Where(p => p.Id == 30).SingleOrDefault();     // Trás apenas um elemento, e se não tiver, trás vazio
            Console.WriteLine("Single or default, test 2: " + r9);
            Console.WriteLine();
        }
    }
}

