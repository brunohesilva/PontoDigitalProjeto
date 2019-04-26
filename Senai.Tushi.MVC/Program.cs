using System;
using Senai.Tushi.MVC.Utils;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcaoDeslogado = 0;
            do
            {
                MenuUtil.MenuDeslogado();
                opcaoDeslogado = int.Parse(Console.ReadLine());
                switch (opcaoDeslogado)
                {
                    case 1:
                    break;
                    case 2:
                    break;
                    case 3:
                    break;
                    case 0:
                    break;

                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }

            } while (opcaoDeslogado != 0);
        }
    }
}
