using System;
using System.IO;   // Para usar FileStream

namespace Course16Streams
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\izabela\Documents\Ash\Curso Csharp Udemy\Projetos Estudo\file1.txt";

            //FileStream fs = null;   // Pode ler ou escrever
            StreamReader sr = null; // Lê uma stream binária

            try
            {
                //fs = new FileStream(path, FileMode.Open);   // Abre o arquivo
                //sr = new StreamReader(fs);   // Lê o arquivo

                sr = File.OpenText(path);   // Faz o mesmo que o FileStream e StreamReader juntos

                while (!sr.EndOfStream) // Enquanto não estiver no fim do arquivo
                {
                    string line = sr.ReadLine();    // lê uma linha
                    Console.WriteLine(line);    // mostra a linha
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                // Independente se der erro ou não, vai fechar os arquivos
                if (sr != null) sr.Close();
                //if (fs != null) fs.Close();
            }
        }
    }
}
