using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09Matrizes
{
    class Program
    {
        static void Main(string[] args)
        {
            /* // Teoria / Introdução
            double[,] mat = new double[2, 3];       // Instanciando uma matriz de 2 linhas e 3 colunas
            Console.WriteLine(mat.Length);          // Tamanho da matriz
            Console.WriteLine(mat.Rank);            // Quantidade de linhas
            Console.WriteLine(mat.GetLength(0));    // Pega a primeira dimensão da matriz (no caso, 2)
            Console.WriteLine(mat.GetLength(1));    // Pega a segunda dimensão da matriz (no caso, 3) */

            Console.WriteLine("+++ Criação de Matrizes +++");

            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[n, n];

            for (int i = 0; i < n; i++)   // para percorrer linhas
            {
                string[] values = Console.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)   // para percorrer colunas
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            Console.Write("Main diagonal:");
            for(int i = 0; i < n; i++)
            {
                Console.Write(mat[i,i] + " ");
            }

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (mat[i,j] < 0)
                    {
                        count++;
                    }
                }
            }
            Console.WriteLine("\nNegative numbers: " + count);

        }
    }
}
