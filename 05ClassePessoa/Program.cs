using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExerciciosCsharpOO
{
    class Program
    {
        static void Main(string[] args)
        {

            // Q: Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais velha

            Pessoa p1, p2;

            p1 = new Pessoa();
            p2 = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            p1.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            p2.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            string maisVelha = string.Empty;

            if (p1.Idade > p2.Idade) {
                maisVelha = p1.Nome;
            }
            else if (p1.Idade < p2.Idade) {
                maisVelha = p2.Nome;
            }
            else {
                maisVelha = "Ambos possuem a mesma idade!";
            }

            Console.WriteLine("Pessoa mais velha: " + maisVelha);
        }
    }
}
