using System;
using System.Collections.Generic;
using Senai.TodoList.MVC.Repositorio;
using Senai.TodoList.MVC.Utils;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.ViewController
{
    public class UsuarioViewController
    {
         static UsuarioRepositorio usuarioRepositorio = new UsuarioRepositorio();
        // UsuarioViewModel[]
        public static void CadastrarUsuario(){
                string nome, email, senha, confirmaSenha;
            do
            {
                Console.WriteLine("Digite o Nome do Usuário");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Nome inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Digite o email do usuário");
                email = Console.ReadLine();
                
                if (!ValidacaoUtil.ValidarEmail(email)){
                    Console.WriteLine("Email inválido, o emial de conter @ e .");
                }
            } while (!ValidacaoUtil.ValidarEmail(email));

            do
            {
                Console.WriteLine("Digite a senha do usuário");
                senha = Console.ReadLine();

                Console.WriteLine("Confirme a senha");
                confirmaSenha = Console.ReadLine();

                if (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha))
                {
                    Console.WriteLine("As senhas não são iguais");           
                }
            } while (!ValidacaoUtil.ConfirmacaoSenha(senha,confirmaSenha));

            UsuarioViewModel usuarioViewModel = new UsuarioViewModel();
            usuarioViewModel.Nome = nome;
            usuarioViewModel.Email = email;
            usuarioViewModel.Senha = senha;


            usuarioRepositorio.Inserir(usuarioViewModel);
            Console.WriteLine("Cadastro efetuado com sucesso!");

        }

        public static void ListarUsuario()
        {
           List<UsuarioViewModel> listaDeUsuarios = usuarioRepositorio.Listar();
           foreach (var item in listaDeUsuarios)
           {
               Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Email: {item.Email} - Senha: {item.Senha} - Data de Criação: {item.DataCriacao}");
           }
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