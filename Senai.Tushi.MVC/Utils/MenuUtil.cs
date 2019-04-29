using System;

namespace Senai.Tushi.MVC.Utils {
    public class MenuUtil {
        public static void MenuDeslogado () {
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-------------TSUSHI------------");
            Console.WriteLine ("-----(1) Cadastrar Usuário-----");
            Console.WriteLine ("-----(2) Efetuar Login---------");
            Console.WriteLine ("-----(3) Lista-----------------");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("------Escolha uma Opção--------");
        }

        public static void MenuLogado(){
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("-------------Restaurante TsuShi-------------");
            Console.WriteLine("------------------Cardápio------------------");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("          (1) Cadastrar Produto             ");
            Console.WriteLine("          (2) Listar todos os produtos      ");
            Console.WriteLine("          (3) Buscar produto por Id         ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("          (9) Sair                          ");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("          Escolha uma opção                 ");
        }
    }
}