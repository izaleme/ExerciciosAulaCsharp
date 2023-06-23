using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            // Specify the data source
            int[] numbers = new int[] { 2, 3, 4, 5 };

            // Define the query expression
            IEnumerable<int> result = numbers   // IEnumerable para tratar de uma lista genérica, mas podia ser apenas "var"
                .Where(x => x % 2 == 0)         // Predicato que retorna somente nº pares
                .Select(x => x * 10);           // A expressão lâmbda "x => x * 10" significa que recebe "x" e retorna "x * 10"

            // Execute the query
            foreach (int x in result)
            {
                Console.WriteLine(x);
            }

        }
    }
}
