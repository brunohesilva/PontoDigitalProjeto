using System;

namespace ArrayCaixa
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] notas = {2,5,10,20,50,100};

            Console.WriteLine("Caixa Eletronico");
            Console.WriteLine();
            Console.Write("Digite o valor do saque: ");
            int valor = Convert.ToInt16(Console.ReadLine());
            int n100 = valor / 100;
            int resto = valor - (n100 * 100); 
            int n50 = resto / 50;
            resto = resto - (n50 * 50);
            int n20 = resto / 20;
            resto = resto - (n20 * 20);
            int n10 = resto / 10;
            resto = resto - (n10 * 10);
            int n5 = resto / 5; 
            resto = resto - (n5 * 5);
            int n2 = resto / 2;
            resto = resto - (n2 * 2);
            int n1 = resto / 1;
            resto = resto - (n1 * 1);

            Console.WriteLine();
            Console.WriteLine("Quantidade de notas:");
            Console.WriteLine();
            Console.WriteLine("Notas de 100R$:  " +n100);
            Console.WriteLine();
            Console.WriteLine("Notas de 50R$:  " +n50);
            Console.WriteLine();
            Console.WriteLine("Notas de 20R$:  " +n20);
            Console.WriteLine();
            Console.WriteLine("Notas de 10R$:  " +n10);
            Console.WriteLine();
            Console.WriteLine("Notas de 5R$:  " +n5);
             Console.WriteLine();
            Console.WriteLine("Notas de 2R$:  " +n2);
            Console.WriteLine();
            Console.WriteLine("Notas de 1R$:  " +n1);
            Console.WriteLine();
            Console.WriteLine("Roubamos todo o seu dinheiro kkkkkk");
        }
    }
}
