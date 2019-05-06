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

        //       bool querSair = false;
        // string[] itensMenuPrincipal = Enum.GetNames (typeof (FormacaoEnum));

        // var opcoesFormacao = new List<string>()
        //                             {"    - 0                         ",
        //                              "    - 1                     ",
        //                              "    - 2                     "};

        // int opcaoFormacaoSelecionada = 0;

        // string menuBar = "===================================";

        // do {
        //     bool formacaoEscolhida = false;

        //     do {
        //         Console.Clear ();

        //         System.Console.WriteLine (menuBar);
        //         Console.BackgroundColor = ConsoleColor.DarkCyan;
        //         Console.ForegroundColor = ConsoleColor.Black;
        //         System.Console.WriteLine ("     Seja bem-vindo(a) Vocal!      ");
        //         System.Console.WriteLine ("        Escolha uma formação:      ");
        //         Console.ResetColor ();
        //         System.Console.WriteLine (menuBar);

        //         for (int i = 0; i < opcoesFormacao.Count; i++)
        //         {
        //             string titulo = TratarTituloMenu(itensMenuPrincipal[i]);

        //             if (opcaoFormacaoSelecionada == i) {
        //                 DestacarOpcao(opcoesFormacao[opcaoFormacaoSelecionada].Replace("-", ">").Replace(i.ToString(), titulo));
        //             } else {
        //                 System.Console.WriteLine(opcoesFormacao[i].Replace(i.ToString(), titulo));
        //             }
        //         }

        //         var key = Console.ReadKey(true).Key;

        //         switch(key) {
        //             case ConsoleKey.UpArrow:
        //                 opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == 0 ? opcaoFormacaoSelecionada : --opcaoFormacaoSelecionada;

        //             break;
        //             case ConsoleKey.DownArrow:
        //                 opcaoFormacaoSelecionada = opcaoFormacaoSelecionada == opcoesFormacao.Count - 1 ? opcaoFormacaoSelecionada : ++opcaoFormacaoSelecionada;

        //             break;
        //             case ConsoleKey.Enter:
        //                 formacaoEscolhida = true;
        //                 break;
        //         }

        //     } while(!formacaoEscolhida);

        // } while(!querSair);

        // public static void DestacarOpcao(string opcao) {
        //     Console.BackgroundColor = ConsoleColor.DarkRed;
        //     System.Console.WriteLine(opcao);
        //     Console.ResetColor();
        // }

        // public static string TratarTituloMenu(string titulo) {
        //     return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(titulo.Replace ("_", " ").ToLower ());
        // }
    }
}