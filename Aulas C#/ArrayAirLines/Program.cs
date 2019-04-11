using System;

namespace ArrayAirLines
{
    class Program
    {
        static void Main(string[] args)
        {
            // // string respostas = "";
            // int[] pessoa = new int[5];
            // int[] numPassage = new int[5];
                
            // Console.WriteLine("Bem vindo á OnurAirLines");
            // Console.WriteLine("------------------------");
            // Console.WriteLine("1- Registrar Passagem");
            // Console.WriteLine("2- Visualizar Passagens");
            // Console.WriteLine("0- Sair");
            // Console.WriteLine("------------------------");

            //     Console.WriteLine("Nome do Comprador");
            //     Console.ReadLine();

            //     Console.WriteLine("Número da Passagem");
            //     Console.ReadLine();

            //     Console.WriteLine("Data do voo");
            //     DateTime data = DateTime.Parse(Console.ReadLine());
            

            // int resposta = int.Parse(Console.ReadLine());
            // Console.WriteLine("OBRIGAO POR NADA!!!");
               int resposta, contador = 0;
           string[] nomes = new string[2];
           int[] numeroPassagens = new int[2];
           DateTime[] datas = new DateTime[2];

           Console.WriteLine ("Bem Vindo a Sportore Air Lines");

           do {
               Console.WriteLine ("Escolha uma opção");
               Console.WriteLine ("1 - Registrar Passagem");
               Console.WriteLine ("2 - Exibir Passagens");
               Console.WriteLine ("0 - Sair");
               resposta = int.Parse (Console.ReadLine ());

               switch (resposta) {
                   case 1:
                       //Registrar uma passagem
                       if(contador < 2){
                       Console.WriteLine("Digite o nome do passageiro");
                       nomes[contador] = Console.ReadLine();
                       Console.WriteLine("Digite o Nº da Passagem");
                       numeroPassagens[contador] = int.Parse(Console.ReadLine());
                       Console.WriteLine("Digite a data do Voo");
                       datas[contador] = DateTime.Parse(Console.ReadLine());
                       contador++;
                       }else{
                           Console.WriteLine("Limite excedido");
                       }
                       break;
                   case 2:
                       // Listar os registros
                       int contadorE = 0;
                       while(contadorE < contador){
                           Console.WriteLine($"Passageiro Nº{contadorE+1}");
                           Console.WriteLine($"Nome: {nomes[contadorE]}");
                           Console.WriteLine($"Numero da passagem {numeroPassagens[contadorE]}");
                           Console.WriteLine($"Data do Voo dia {datas[contadorE].Day} de {datas[contadorE]:MMMM} de {datas[contadorE].Year}");
                           contadorE++;
                       };

                       break;
                   case 0:
                       Console.WriteLine ("A Sportore Air Lines agradece a preferência");
                       break;

                   default:
                       Console.WriteLine ("Valor inválido, seleciona outra opção");
                       break;
               } //fim switch

           } while (resposta != 0);
        }
    }
}
