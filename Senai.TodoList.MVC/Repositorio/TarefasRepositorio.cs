using System;
using System.Collections.Generic;
using System.IO;
using Senai.TodoList.MVC.ViewModel;

namespace Senai.TodoList.MVC.Repositorio {
    public class TarefasRepositorio {
        public TarefasViewModel InserirTarefa (TarefasViewModel tarefas) {
            int contador = 0;
            List<TarefasViewModel> listaDeTarefas = ListarTarefas ();
            if (listaDeTarefas != null) {
                contador = listaDeTarefas.Count;
            }

            tarefas.Id = listaDeTarefas.Count + 1;
            tarefas.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter ("tarefas.csv", true);
            sw.WriteLine ($"{tarefas.Id};{tarefas.Nome};{tarefas.Descricao};{tarefas.TipoPFFF};{tarefas.DataCriacao}");
            sw.Close ();

            return tarefas;
        }

        public List<TarefasViewModel> ListarTarefas () {
            List<TarefasViewModel> listaDeTarefas = new List<TarefasViewModel> ();
            TarefasViewModel tarefasViewModel;
            if (!File.Exists ("tarefas.csv")) {
                return null;
            }
            string[] tarefas = File.ReadAllLines ("tarefas.csv");

            foreach (var item in tarefas) {
                if (item != null) {

                    string[] dadosDeCadaTarefa = item.Split (";");
                    tarefasViewModel = new TarefasViewModel ();
                    tarefasViewModel.Id = int.Parse (dadosDeCadaTarefa[0]);
                    tarefasViewModel.Nome = dadosDeCadaTarefa[1];
                    tarefasViewModel.TipoPFFF = dadosDeCadaTarefa[2];
                    tarefasViewModel.Descricao = dadosDeCadaTarefa[3];
                    tarefasViewModel.DataCriacao = DateTime.Parse (dadosDeCadaTarefa[4]);
                    listaDeTarefas.Add (tarefasViewModel);
                }
            }
            return listaDeTarefas;
        }
    }
}