using System;
using System.IO;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\victorhmalta\source\repos\file1.txt";
            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                fs = new FileStream(path, FileMode.Open); //Abre o caminho fornecido
                sr = new StreamReader(fs); //Lê o conteúdo
                string line = sr.ReadLine(); //Lê uma linha e armazena na variável
                Console.WriteLine(line); //Imprime a variável na tela
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred!");
                Console.WriteLine(e.Message);
            }
            finally
            {
                //É necessário fechar o arquivo manualmente por enquanto!
                if (fs != null) fs.Close();
                if (sr != null) sr.Close();
            }
        }
    }
}
