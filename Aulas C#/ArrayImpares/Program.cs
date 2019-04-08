using System;

namespace ArrayImpares {
    class Program {
        static void Main (string[] args) {
     
       // int[] impares = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
            // int impares = 0;

            // for (int i = 0; i < numeros.Length; i++) {
            //     if (numeros[i] % 2 != 0)
            //     {
            //         impares++;
            //         System.Console.WriteLine (numeros[i]);
            //     }
            // }
            // System.Console.WriteLine($"Total:{impares}");

            int[] numeroCasa = new int[5];
            for (int i = 0; i < numeroCasa.Length; i++) {
                numeroCasa[i] = int.Parse(Console.ReadLine());
            }

            foreach (var numeros in numeroCasa)
            {
                System.Console.Write($"{numeroCasa},");
            }
        }
    }
}