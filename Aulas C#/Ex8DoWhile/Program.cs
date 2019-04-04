using System;

namespace Ex8DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            // // bool jaAcordei = false;

            // // do {
            // //     System.Console.WriteLine("Pai, voCê já acordou?");
            // //     string resposta = Console.ReadLine();

            // //     jaAcordei = resposta.Contains("que") ? true : false;
            // // } while (!jaAcordei);

            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("*");
            //     // Console.WriteLine("**");
            //     // Console.WriteLine("***");
            //     // Console.WriteLine("****");
            //     // Console.WriteLine("******");
            //     // Console.WriteLine("*******");
            //     // Console.WriteLine("********");
            //     // Console.WriteLine("*********");
            //     // Console.WriteLine("**********");
            //     // Console.WriteLine("***********");
            //     // Console.WriteLine("************");
            //     // Console.WriteLine("*************");
            //     // Console.WriteLine("**************");
            //     // Console.WriteLine("***************");
            //     // Console.WriteLine("****************");
            //     // Console.WriteLine("*****************");
            //     // Console.WriteLine("******************");
            //     // Console.WriteLine("*******************");
            //     // Console.WriteLine("********************");
            //     // Console.WriteLine("*********************");
            //     // Console.WriteLine("**********************");
            //     // Console.WriteLine("***********************");
            //     // Console.WriteLine("************************");
            // }
            // Console.WriteLine("");
            // Console.WriteLine("Defina quantas estrelas você quer?");

            // Console.ReadLine();
            // Console.ReadLine();
            
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("**");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("***");
            // }
            //  for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("****");
            // }
            //  for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("*****");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("******");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("*******");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("********");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("*********");
            // }
            // for (int  i = 0; i < 1; i++)
            // {
            //     Console.WriteLine("**********");
            // }

            int tamanhoTriangulo = int.Parse(Console.ReadLine());
            string estrela = "";

            for (int i = 0; i < 100; i++)
            {
                estrela += "*";
                Console.WriteLine(estrela);
            }

        }
    }
}