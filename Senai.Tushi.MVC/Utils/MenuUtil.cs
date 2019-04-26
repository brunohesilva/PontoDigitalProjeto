using System;

namespace Senai.Tushi.MVC.Utils
{
    public class MenuUtil
    {
        public static void MenuDeslogado(){
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------TSUSHI------------");
            Console.WriteLine("-----(1) Cadastrar Usuário-----");
            Console.WriteLine("-----(2) Efetuar Login --------");
            Console.WriteLine("-----(3) Lista ----------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------Escolha uma Opção-------");
        }
    }
}