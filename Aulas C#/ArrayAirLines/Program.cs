using System;

namespace ArrayAirLines
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine ("Bem-vindo à Tsukamoto Airlines");
            bool sair = false;
            Passageiro[] passageiros = new Passageiro[2];
            int passageirosCadastrados = 0;

            do {
                System.Console.WriteLine ("Escolha uma opção:");
                System.Console.WriteLine ("1 - Registrar Passageiro");
                System.Console.WriteLine ("2 - Exibir Passagens");
                System.Console.WriteLine ("0 - Sair");

                int codigo = int.Parse (Console.ReadLine ());

                switch (codigo) {
                    case 1:
                        
                        System.Console.WriteLine ("Digite o nome do passageiro");
                        Passageiro p = new Passageiro ();
                        p.setNome (Console.ReadLine ());
                        passageiros[passageirosCadastrados] = p;                       

                        passageirosCadastrados++;
                        System.Console.WriteLine ("Passageiro cadastrado com sucesso!");

                        
                        break;
                    case 2:

                        System.Console.WriteLine ("Todos os passageiros cadastrados");
                        foreach (var passageiro in passageiros) {
                            if (passageiro != null) {
                                System.Console.WriteLine (passageiro.getNome ());
                            }
                        }

                        break;
                    case 0:
                        sair = true;
                        break;

                }

            } while (!sair);
        }    
    }
}
