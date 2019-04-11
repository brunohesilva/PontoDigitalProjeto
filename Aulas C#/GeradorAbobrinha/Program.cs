using System;

namespace GeradorAbobrinha
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine ("Escreve uma palavra aí, meu consagrado!");

           int maxPalavrasUsuario = 5;
           int maxPalavrasFrase = 8;

           string[] palavrasUsuario = new string[maxPalavrasUsuario];

           for (int i = 0; maxPalavrasUsuario > 0; i++) {
               palavrasUsuario[i] = Console.ReadLine ();
               if (--maxPalavrasUsuario != 0) {
                   System.Console.WriteLine ($"Faltam {maxPalavrasUsuario}. Digite mais uma!");
               } else {
                   System.Console.WriteLine ("Valeu, jovem! Agora deixa comigo!");
               }
           }

           string[, ] matrizPalavras = { { "Naruto", "duro", "pai", "", "no" },
                                         { "caiu", "matar", "", "Corrompe", "capotar" },
                                         { "prisão", "com", "embaixo", "", "dentro" },
                                         { "chão", "corsa", "", "vem", "ditador" },
                                         { "lá", "sabonete", "tranquilo", "", "Cavalo" }
           };

           for (int i = 0; i < matrizPalavras.GetLength (0); i++) {
               for (int j = 0; j < matrizPalavras.GetLength (0); j++) {
                   if("".Equals(matrizPalavras[i,j])) {
                       matrizPalavras[i,j] = palavrasUsuario[i];
                   }
               }
           }

           string frase = "";

           Random r = new Random();
           for (int i = 0; i < maxPalavrasFrase; i++) {
               frase += matrizPalavras[r.Next(matrizPalavras.GetLength(0)), //i
                                       r.Next(matrizPalavras.GetLength(0))] //j
                                       + " ";
           }
           System.Console.WriteLine("Minha frase é: \n" + frase);

        //     int y = 1;
        //    // Retorna imediatamente o decremento
        //    int prefixo = 1 + --y;
        //    Console.WriteLine($"--y = {prefixo} {y}");

        //    y = 1;
        //    // Decrementa depois de associar o valor
        //    int sufixo = 1 + y--;
        //    Console.WriteLine($"y-- = {sufixo} {y}");
        }    
    }
}
