using System;

namespace ForDuplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 3;
            int colunas =3;

            for (int i = 3; i <= linhas; i++) {
                for (int j = 3; j <= colunas; j++) {
                    System.Console.WriteLine($"[{i},{j}]");
                }
            }
            //    string estrela = "";

            // for (int i = 0; i < 100; i++)
            // {
            //     estrela += "*";
            //     Console.WriteLine(estrela);
            // }
        }
    }
}
