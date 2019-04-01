using System;

namespace SugestaoPasseio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Diga-me a previsão do tempo, e lhe direi o que fazer.");
            string clima = Console.ReadLine().ToLower();

            if (clima.Equals("frio")) 
            {
                Console.WriteLine("Vamos à montanha!");
            }
            else if (clima.Equals("calor")) 
            {
                Console.WriteLine("Vamos à praia!");
            }
            else if (clima.Equals("chuva"))
            {
                Console.WriteLine("Vamos para a Steam?");
                string resposta = Console.ReadLine();
                if (resposta.Equals("Não"))
                {
                    Console.WriteLine("Vamos para a Netflix!");
                }
            }else{
                Console.WriteLine("Valor inválido \n Digite: chuva, frio ou calor.");
            }
        }
    }
}
