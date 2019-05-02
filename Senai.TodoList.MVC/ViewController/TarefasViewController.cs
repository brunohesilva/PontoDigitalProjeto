using System;
using System.Collections.Generic;
using Senai.TodoList.MVC.Enums;
using Senai.TodoList.MVC.Repositorio;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.ViewController
{
    public class TarefasViewController
    {
        static TarefasRepositorio tarefasRepositorio = new TarefasRepositorio();

        public static void DeterminarTarefas(){
            string nome, descricao, tipo;
            int idUsuario;


            do
            {
                Console.WriteLine("Digite o Nome da Tarefa");
                nome = Console.ReadLine();

                if (string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Tarefa Inválida");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Descreva a Tarefa");
                descricao = Console.ReadLine();

                if (string.IsNullOrEmpty(descricao)){
                    Console.WriteLine("Descrição Inválida");
                }
            } while (string.IsNullOrEmpty(descricao));

            do
            {
                Console.WriteLine("Situação da Tarefa (1)PARA FAZER - (2)FAZENDO - (3)FEITO");
                tipo = Console.ReadLine();

            } while (string.IsNullOrEmpty(tipo));

            do
            {
                Console.WriteLine("Digite o Usuário");
                idUsuario = int.Parse(Console.ReadLine());

            } while (false);

            TarefasViewModel tarefaViewModel = new TarefasViewModel();
            tarefaViewModel.Nome = nome;
            tarefaViewModel.Descricao = descricao;
            tarefaViewModel.TipoPFFF = tipo;
            tarefaViewModel.IdUsuario = idUsuario;

            tarefasRepositorio.InserirTarefa(tarefaViewModel);

            Console.WriteLine("Tarefa cadastrada com sucesso");
        }

        static void MonstrarMensagem(string mensagem, TipoMensagemEnum tipoMensagem){
            switch (tipoMensagem){
                case TipoMensagemEnum.PARA_FAZER:
                Console.ForegroundColor = ConsoleColor.Green;
                break;
                case TipoMensagemEnum.FAZENDO:
                Console.ForegroundColor = ConsoleColor.Yellow;
                break;
                case TipoMensagemEnum.FEITO:
                Console.ForegroundColor = ConsoleColor.Red;
                break;
                default:
                break;
            }
             System.Console.WriteLine (mensagem);
            Console.ResetColor ();
            System.Console.WriteLine ("\nAperte ENTER para voltar ao menu principal");
            Console.ReadLine ();
        }

        public static void ListarTarefas(){

            List<TarefasViewModel> listaDeTarefas = tarefasRepositorio.ListarTarefas();
            foreach (var item in listaDeTarefas){
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descricao} - Tipo: {item.TipoPFFF}");
            }
        }
    }
}