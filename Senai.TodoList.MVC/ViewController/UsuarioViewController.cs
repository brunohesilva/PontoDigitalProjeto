using System;
using Senai.TodoList.MVC.Repositorio;
using Senai.TodoList.MVC.Utils;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.ViewController
{
    public class UsuarioViewController
    {
         static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        public static void CadastrarUsuario(){
            string nome, email, senha, confirmaSenha, tipo;

            do
            {
                Console.WriteLine("Digite o Nome do Usuário");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Nome Inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Digite o Email do Usuário");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    Console.WriteLine("Email inválido, o email deve conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite a Senha do Usuário");
                senha = Console.ReadLine();

                Console.WriteLine("Confirme a Senha");
                confirmaSenha = Console.ReadLine();
                if (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha)){
                    Console.WriteLine("As senhas não são iguais");
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha, confirmaSenha));

            do
            {
                Console.WriteLine("Digite o Tipo de Usuário ou Admin");
                tipo = Console.ReadLine();
                if (string.IsNullOrEmpty(tipo)){
                    Console.WriteLine("Tipo Inválido");
                }
            } while (string.IsNullOrEmpty(tipo));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;
            usuarioViewModel.TipoUA = tipo;

            usuarioRepositorio.Inserir(usuarioViewModel);

            Console.WriteLine("Cadastrado efetuado com sucesso!");
        }

        public static UsuarioViewModel EfetuarLogin(){
            string email, senha;

            do
            {
                Console.WriteLine("Insira o email");
                email = Console.ReadLine();
                if (!ValidacaoUtil.ValidarEmail(email)){
                    Console.WriteLine("Emaail Inválido");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            Console.WriteLine("Digite a senha");
            senha = Console.ReadLine();

             UsuarioViewModel usuarioRecuperado = usuarioRepositorio.BuscarUsuario(email, senha);
            if (usuarioRecuperado != null)
            {
                return usuarioRecuperado;
            }else{
                Console.WriteLine("Email ou senha inválida");
                return null;
            }
        }
    }
}