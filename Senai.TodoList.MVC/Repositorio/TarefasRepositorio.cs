using System;
using System.Collections.Generic;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.Repositorio
{
    public class TarefasRepositorio
    {
        List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel>();

        public TarefasViewModel InserirTarefa(TarefasViewModel tarefas){
            tarefas.Id = listaDeTarefas.Count +1;
            tarefas.DataCriacao = DateTime.Now;

            listaDeTarefas.Add(tarefas);

            return tarefas;
        }

        public List<TarefasViewModel> ListarTarefas(){
            return listaDeTarefas;
        }
    }
}