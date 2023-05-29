using System;
using System.IO;   // Para usar FileStream

namespace Course16Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\izabela\Documents\Ash\Curso Csharp Udemy\Projetos Estudo\file1.txt";

            try
            {
                // O bloco using automaticamente fecha os arquivos que ele abrir
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)     // Enquanto não estiver no fim do arquivo
                    {
                        string line = sr.ReadLine();    // lê uma linha
                        Console.WriteLine(line);    // mostra a linha
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
        }
    }
}
