using System;
using System.IO;
using System.Collections.Generic;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\victorhmalta\source\repos\myfolder";

            try
            {
                //Cria um diretório no caminho indicado, podendo ser concatenado com path
                Directory.CreateDirectory(path + @"\newfolder");

                //Os métodos de enumeração de diretórios e arquivos são do tipo IEnumerable, uma coleção diferente em System.Collections.Generic
                IEnumerable<string> folders =  Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);//A máscara "*.*" pega todos os nomes e tipos
                Console.WriteLine("FOLDERS: ");
                foreach (string folder in folders)
                {
                    Console.WriteLine(folder);
                }

                //Mesma coisa só que com arquivos
                IEnumerable<string> files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES: ");
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
