using System;
using System.Collections.Generic;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC.Repositorio
{
    public class ProdutoRepositorio
    {

        List<ProdutoViewModel> listaDeProdutos = new List<ProdutoViewModel>();
        public ProdutoViewModel InserirProduto(ProdutoViewModel produto){
            produto.Id = listaDeProdutos.Count +1;
            produto.DataCriacao = DateTime.Now;

            listaDeProdutos.Add(produto);

            return produto; 
        }

        public List<ProdutoViewModel> ListarProduto(){
            return listaDeProdutos;
        }

        public ProdutoViewModel BuscarId(string id)
        {
            foreach (var item in listaDeProdutos)
            {
                if (item.Id.Equals(id)) 
                {
                    return item;
                }

            }
                return null;
        }
    }
}