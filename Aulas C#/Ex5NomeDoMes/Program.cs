﻿using System;

namespace Ex5NomeDoMes
{
    class Program
    {
        static void Main(string[] args)
        {

            // int num = 1;

            // while (num != 0) {
            // Console.WriteLine("Entre com o número do mês ou 0 para sair:");
            // num = int.Parse(Console.ReadLine());

            // switch (num) {   
            //     case 1:
            //         Console.WriteLine("Janeiro");
            //         break;
            //     case 2:
            //         Console.WriteLine("Fevereiro");
            //         break;
            //     case 3:
            //         Console.WriteLine("Março");
            //         break;
            //     case 4:
            //         Console.WriteLine("Abril");
            //         break;
            //     case 5:
            //         Console.WriteLine("Maio");
            //         break;
            //     case 6:
            //         Console.WriteLine("Junho");
            //         break;
            //     case 7:
            //         Console.WriteLine("Julho");
            //         break;
            //     case 8:
            //         Console.WriteLine("Agosto");
            //         break;
            //     case 9:
            //         Console.WriteLine("Setembro");
            //         break;
            //     case 10:
            //         Console.WriteLine("Outubro");
            //         break;
            //     case 11:
            //         Console.WriteLine("Novembro");
            //         break;
            //     case 12:
            //         Console.WriteLine("Dezembro");
            //         break;
            //     default:
            //         Console.WriteLine("Escolha um número ente 1 e 12");
            //         break;
            //     }
            // }

            bool usuarioAindaQuerJogar = true;

            int cont = 3;

            while(cont >= 1 && usuarioAindaQuerJogar) {
                System.Console.WriteLine("Você tem mais {0} chances!", cont);
                string resposta = Console.ReadLine();
                usuarioAindaQuerJogar = resposta.Equals("sim") ? true : false;
                cont--;
            }

        }
    }
}
