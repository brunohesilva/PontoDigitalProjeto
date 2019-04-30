using System;
using Senai.TodoList.MVC.Utils;
using Senai.TodoList.MVC.ViewController;

namespace Senai.TodoList.MVC
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
                switch (opcaoDeslogado){
                    case 1:
                    UsuarioViewController.CadastrarUsuario();
                    break;
                    case 2:
                    UsuarioViewController.EfetuarLogin();
                    break;
                    default:
                    Console.WriteLine("Opção Inválida");
                    break;
                }               
            } while (opcaoDeslogado != 0);
        }
    }
}
