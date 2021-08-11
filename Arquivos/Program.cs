using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\victorhmalta\source\repos\file1.txt";

            try
            {
                //O bloco using permite que se termine automaticamente a execução de um objeto IDisposable: Font, FileStream, StreamReader, StreamWriter...

                //É possível fazer em cascata e instanciar logo no início da execução
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                    }
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
