using System;
using Senai.Tushi.MVC.Utils;
using Senai.Tushi.MVC.ViewController;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC {
    class Program {
        static void Main (string[] args) {
            int opcaoDeslogado = 0;
            int opcaoLogado = 0;
            
            do {
                MenuUtil.MenuDeslogado ();
                opcaoDeslogado = int.Parse (Console.ReadLine ());
                switch (opcaoDeslogado) {
                    case 1:
                    UsuarioViewController.CadastrarUsuario();
                        break;
                    case 2:
                    UsuarioViewModel usuarioRecuperado = UsuarioViewController.EfetuarLogin();
                    if (usuarioRecuperado != null){
                        Console.WriteLine($"Seja bem vindo - {usuarioRecuperado.Nome}");

                        do
                        {
                            MenuUtil.MenuLogado ();
                            opcaoLogado = int.Parse (Console.ReadLine());
                            
                            switch (opcaoLogado){
                                case 1:
                                break;
                                case 2:
                                break;
                                case 3:
                                break;
                                case 9:
                                break;
                                default:
                                Console.WriteLine ("Opção Inválida");
                                break;
                            }
                        } while (opcaoLogado != 0);
                    }
                        break;
                    case 3:
                    UsuarioViewController.ListarUsuario();
                        break;
                    case 0:
                        break;

                    default:
                        Console.WriteLine ("Opção Inválida");
                        break;
                }
            } while (opcaoDeslogado != 0);
        }
    }
}

