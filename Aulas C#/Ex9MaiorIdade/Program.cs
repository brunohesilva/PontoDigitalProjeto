using System;

namespace Ex9MaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maiores = 0;
            int menores = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite a idade");
                int idade = int.Parse(Console.ReadLine());

                if (idade >= 18)
                {
                    maiores++;        
                }else{
                    menores++;
                }
            }
            Console.WriteLine("A quantidade de maiores de idade é: {0}", maiores);
            Console.WriteLine("A quantidade de menore de idade é: {0}", menores);
        }
    }
}
