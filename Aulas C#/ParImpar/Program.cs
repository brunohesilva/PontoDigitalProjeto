using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Você quer jogar um jogo?!");
            string resposta = Console.ReadLine();
            
            
            if (resposta.Equals("não")) 
            {
                Console.WriteLine("Você não é digno de perder");
            }
            else if (resposta.Equals("sim")){
                Random r = new Random();
                int numeroPc = r.Next(0,10);

                Console.WriteLine("Escolha Par ou Ímpar");
                string escolha = Console.ReadLine();
                
                if (escolha.Equals("Par"))
                {
                    if (numeroPc.Equals(numeroPc % 2 == 0))
                    {
                        Console.WriteLine("Sua vitória não e nada mais que minha derrota");
                    }
                    else 
                    {
                        Console.WriteLine("Parece que eu venci!!!;)");
                    }
                }
                if (escolha.Equals("Ímpar"))
                {
                    if (numeroPc.Equals(numeroPc % 2 == 1))
                    {
                        Console.WriteLine("Sua vitória não e nada mais que minha derrota");
                    }
                    else 
                    {
                        Console.WriteLine("Parece que eu venci!!!;)");
                    }
                }
            }
        }
    }
}
