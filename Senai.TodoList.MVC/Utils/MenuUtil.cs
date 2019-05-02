using System;

namespace Senai.TodoList.MVC.Utils {
    public class MenuUtil {
        public static void MenuDeslogado () {

            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-----------TODO LIST-----------");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-----(1) Cadastrar Usuário-----");
            Console.WriteLine ("-----(2) Efetuar Login---------");
            Console.WriteLine ("-----(3) Listar Usuários-------");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("------Escolha uma Opção--------");
            Console.WriteLine ("-------------------------------");

        }

        public static void MenuLogado () {
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-----------TRELLO2.0-----------");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-----(1) Cadastrar Tarefas-----");
            Console.WriteLine ("-----(2) Mostrar Tarefas-------");
            Console.WriteLine ("-------------------------------");
            Console.WriteLine ("-------Escolha uma Opção-------");
            Console.WriteLine ("-------------------------------");
        }
    }
}