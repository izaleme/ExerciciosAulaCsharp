using System;

namespace _10StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {

            // Funções para strings ~ ~ ~ ~

            string original = "abcde FGHIJ ABC abc DEFG    ";

            string s1 = original.ToUpper();     // Deixa a string em letras maiúsculas
            string s2 = original.ToLower();     // Deixa a string em letras minúsculas
            string s3 = original.Trim();        // Apaga os espaços em branco

            int n1 = original.IndexOf("bc");        // Pega a posição do primeiro bc
            int n2 = original.LastIndexOf("bc");    // Pega a posição do último bc

            string s4 = original.Substring(3);         // Corta a string a partir da posição 3
            string s5 = original.Substring(3, 5);      // Corta 5 caracteres da string a partir da posição 3

            string s6 = original.Replace('a', 'x');     // Substitui uma string pela outra 
            string s7 = original.Replace("abc", "xy");  // Substitui uma string pela outra 

            int x1 = int.Parse("1");         // Converte uma string para int
            int x2 = Convert.ToInt32("1");   // Converte uma string para int

            bool b1 = String.IsNullOrEmpty(original);   // Verifica se a variavel 'original' é nula ou vazia
            bool b2 = String.IsNullOrWhiteSpace(original);   // Verifica se a variavel 'original' é nula ou são espaços em branco

            // ~ ~ ~ ~

            Console.WriteLine("STRING ORIGINAL: -" + original + "-");

            Console.WriteLine("\n--- Funções de Formatação ---");
            Console.WriteLine("String ToUpper: |" + s1 + "|");
            Console.WriteLine("String ToLower: |" + s2 + "|");
            Console.WriteLine("String Trim:    |" + s3 + "|");

            Console.WriteLine("\n--- Funções de Busca ---");
            Console.WriteLine("IndexOf('bc'):     " + n1);
            Console.WriteLine("LastIndexOf('bc'): " + n2);

            Console.WriteLine("\n--- Funções de Recortar ---");
            Console.WriteLine("Substring(3):   |" + s4 + "|");
            Console.WriteLine("Substring(3,5): |" + s5 + "|");

            Console.WriteLine("\n--- Funções de Substituir ---");
            Console.WriteLine("Replace('a', 'x'):    |" + s6 + "|");
            Console.WriteLine("Replace('abc', 'xy'): |" + s7 + "|");

            Console.WriteLine("\n--- Funções de Conversão ---");
            Console.WriteLine("int.Parse: " + x1);
            Console.WriteLine("Convert.ToInt32: " + x2);

            Console.WriteLine("\n--- Outras funções ---");
            Console.WriteLine("IsNullOrEmpty: " + b1);
            Console.WriteLine("IsNullOrWhiteSpace: " + b2);

            Console.WriteLine();
        }
    }
}
