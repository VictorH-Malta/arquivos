using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;

namespace ExerciseArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Fazer um programa para ler o caminho de um arquivo .csv
              contendo os dados de itens vendidos. Cada item possui um
              nome, preço unitário e quantidade, separados por vírgula. Você
              deve gerar um novo arquivo chamado "summary.csv", localizado
              em uma subpasta chamada "out" a partir da pasta original do
              arquivo de origem, contendo apenas o nome e o valor total para
              aquele item (preço unitário multiplicado pela quantidade),
              conforme exemplo.*/

            string sourcePath = @"C:\Users\victorhmalta\source\repos\myfolder\file1.csv";

            try
            {
                var directory = Directory.CreateDirectory(@"C:\Users\victorhmalta\source\repos\myfolder\out");
                string targetPath = directory + @"\summary.csv";

                //Criando uma variavel que abre o arquivo e lê o que está lá
                using (StreamReader sr = File.OpenText(sourcePath))
                {
                    using (StreamWriter sw = File.AppendText(targetPath))
                    {

                        //Enquanto não terminarem as linhas, faça...
                        while (!sr.EndOfStream)
                        {
                            //Armazendo as linhas na posição
                            string lines = sr.ReadLine();
                            string[] s = lines.Split(',');

                            //Adiciona os itens separados por vírgula na lista
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                {
                                    sw.Write(s[i] + ", ");
                                }

                                if (i == 2)
                                {
                                    double price = double.Parse(s[i - 1], CultureInfo.InvariantCulture);
                                    int quantity = int.Parse(s[i]);
                                    double total = price * quantity;

                                    sw.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
                                }

                            }
                        }
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
