using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**/
            string sourcePath = @"C:\Users\victorhmalta\source\repos\file1.txt";
            string targetPath = @"C:\Users\victorhmalta\source\repos\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);//Instancia um objeto FileInfo
                fileInfo.CopyTo(targetPath);//Pega o conteúdo e copia pro caminho indicado
                string[] lines = File.ReadAllLines(targetPath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
