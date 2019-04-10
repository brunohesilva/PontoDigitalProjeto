using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreve uma palavra aí, meu consagrado!");

            int maxPalavrasUsuario = 5;
            int maxPalavrasFrase = 8;

            string[] maxPalavrasUsuario = new string[maxPalavrasUsuario];

            for (int i = 0; palavrasUsuario > 0; i++)
            {
                PalavrasUsuario[i] = Console.ReadLine();
                if (--maxPalavrasUsuario != 0) {
                    System.Console.WriteLine($"Faltam {maxPalavrasUsuario}. Digite mais uma !");
                } else {
                    System.Console.WriteLine("Valeu, jovem! Agora deixa comigo!");
                }
            }
        }
    }
}
