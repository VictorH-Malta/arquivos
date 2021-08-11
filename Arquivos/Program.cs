using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"C:\Users\victorhmalta\source\repos\file1.txt";
            string targetPath = @"C:\Users\victorhmalta\source\repos\file2.txt";

            try
            {
                //Lê as linhas e guarda o conteúdo no vetor string[] lines
                string[] lines = File.ReadAllLines(sourcePath);

                //Instanciando uma variável StreamWriter e já escrevendo com o método AppendText()
                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach (string line in lines)
                    {
                        //Escreve no arquivo todo o conteúdo em LETRA MAIÚSCULA
                        sw.WriteLine(line.ToUpper());
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
