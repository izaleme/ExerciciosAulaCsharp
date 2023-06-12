using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"]  = "Maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "121212122121212";
            cookies["phone"] = "909090909090900";   // sobrescreve o valor anterior

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            cookies.Remove("email");

            // Tratando a exceção ao tentar exibir uma chave que não existe:
            if (cookies.ContainsKey("email"))
            {
                Console.WriteLine(cookies["email"]);
            }
            else
            {
                Console.WriteLine("There is no 'email' key.");
            }

            Console.WriteLine("\nCookies size: " + cookies.Count);

            Console.WriteLine("\nALL COOKIES:");
            foreach(var item in cookies)            // onde var = KeyValuePair<string, string>
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}
