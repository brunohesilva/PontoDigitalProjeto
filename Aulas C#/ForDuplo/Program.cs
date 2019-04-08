using System;

namespace ForDuplo
{
    class Program
    {
        static void Main(string[] args)
        {
            int linhas = 1;
            int colunas = 215;
            string estrela = "";

            for (int i = 1; i <= linhas; i++) {
                estrela = "";
                for (int j = 1; j <= colunas; j++) {
                    estrela += "*";
                    Console.WriteLine(estrela);
                }
            }
        }
    }
}
