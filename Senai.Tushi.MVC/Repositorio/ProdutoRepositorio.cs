using System;
using System.Collections.Generic;
using System.IO;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC.Repositorio {
    public class ProdutoRepositorio {

        // List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
        public ProdutoViewModel InserirProduto (ProdutoViewModel produto) {
            int contador = 0;
            List<ProdutoViewModel> listaDeProdutos = ListarProdutos ();
            if (listaDeProdutos != null) {
                contador = listaDeProdutos.Count;
            }

            produto.Id = contador + 1;
            produto.DataCriacao = DateTime.Now;

            StreamWriter sw = new StreamWriter ("produtos.csv", true);
            sw.WriteLine ($"{produto.Id};{produto.Nome};{produto.Preco};{produto.Categoria};{produto.Descricao};{produto.DataCriacao}");
            sw.Close ();

            return produto;
        }

        public List<ProdutoViewModel> ListarProdutos () {
            List<ProdutoViewModel> listaDepProdutos = new List<ProdutoViewModel> ();
            ProdutoViewModel produtoViewModel;
            if (!File.Exists ("produto.csv")) {
                return null;
            }
            string[] produtos = File.ReadAllLines ("produtos.csv");

            foreach (var item in produtos) {
                if (item != null) {

                    string[] dadosDeCadaProduto = item.Split (";");
                    produtoViewModel = new ProdutoViewModel ();
                    produtoViewModel.Id = int.Parse (dadosDeCadaProduto[0]);
                    produtoViewModel.Nome = dadosDeCadaProduto[1];
                    produtoViewModel.Preco = float.Parse (dadosDeCadaProduto[2]);
                    produtoViewModel.Categoria = dadosDeCadaProduto[3];
                    produtoViewModel.Descricao = dadosDeCadaProduto[4];
                    produtoViewModel.DataCriacao = DateTime.Parse (dadosDeCadaProduto[5]);
                    listaDepProdutos.Add (produtoViewModel);
                }
            }
            return listaDepProdutos;
        }

        // public ProdutoViewModel BuscarId(string id)
        // {
        //     foreach (var item in listaDeProdutos)
        //     {
        //         if (item.Id.Equals(id)) 
        //         {
        //             return item;
        //         }

        //     }
        //         return null;
        // }
    }
}