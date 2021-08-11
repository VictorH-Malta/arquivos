using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\victorhmalta\source\repos\file1.txt";
            StreamReader sr = null;
            try
            {
                //É possível simplificar sem instanciar um objeto FileStream
                sr = File.OpenText(path);
                while (!sr.EndOfStream) //Enquanto o arquivo não acabar, leia as linhas e armazene
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            finally
            {
                if (sr != null) sr.Close(); //Fecha o arquivo
            }
        }
    }
}
