using System;
using System.IO;

namespace Course17DirectoryAndPath
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Directory and DirectoryInfo

            //string path = @"C:\Users\izabela\Documents\Ash\Curso Csharp Udemy\Projetos Estudo\ExerciciosAulaCsharp\temp_folders";

            //try
            //{
            //    // Mostra todas as pastas no diretório passado
            //    var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Folders:");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    // Mostra todos os arquivos no diretório passado
            //    Console.WriteLine();
            //    var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("Files:");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    // Cria uma nova pasta
            //    Directory.CreateDirectory(path + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            #endregion

            #region Path

            string path = @"C:\Users\izabela\Documents\Ash\Curso Csharp Udemy\Projetos Estudo\ExerciciosAulaCsharp\temp_folders\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

            #endregion
        }
    }
}
