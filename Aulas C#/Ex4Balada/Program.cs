using System;

namespace Ex4Balada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você tá a fim de ir numa balada???");
            string resposta = Console.ReadLine().ToLower();

            if (resposta.Equals("sim"))
            {
                Console.WriteLine("Se tem disponibilidade para o dia e se tem idade para entrar nessa balada (18 ou mais, ou se é matinê)?");

                if (resposta.Equals("sim"))
                {
                    Console.WriteLine("Se você tem pulseira VIP ou pagou a entrada?");
                    
                }
                else if (resposta.Equals("não"))
                {
                    Console.WriteLine("Só menor de idade ou não tempo, não tem prblema falsifique sua identidade em www.identidadefalsa.com.br");
                }
            }
            else if (resposta.Equals("não"))
            {
                Console.WriteLine("Sem tempo irmão, faço Senai.");
            }
        }
    }
}
