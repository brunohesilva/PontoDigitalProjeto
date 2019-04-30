using System;
using System.Collections.Generic;
using Senai.Tushi.MVC.Repositorio;
using Senai.Tushi.MVC.ViewModel;

namespace Senai.Tushi.MVC.ViewController
{
    public class ProdutoViewController
    {
         static ProdutoRepositorio produtoRepositorio = new ProdutoRepositorio();
        public static void CadastrarProduto(){
            string nome, descricao, categoria;
            float preco;

            do
            {
                Console.WriteLine("Digite o Nome do Produto");
                nome = Console.ReadLine();
                if (string.IsNullOrEmpty(nome)){
                    Console.WriteLine("Nome inválido");
                }
            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Digite o Preço do Produto");
                preco = float.Parse(Console.ReadLine());

            } while (false);

            do
            {
                Console.WriteLine("Descreva o Produto");
                descricao = Console.ReadLine();

            } while (false);

            do
            {
                Console.WriteLine("Digite a Categoria do Produto");
                categoria = Console.ReadLine();
                
            } while (false);

            ProdutoViewModel produtoViewModel = new ProdutoViewModel();
            produtoViewModel.Nome = nome;
            produtoViewModel.Descricao = descricao;
            produtoViewModel.Preco = preco;
            produtoViewModel.Categoria = categoria;

            produtoRepositorio.InserirProduto(produtoViewModel);

            Console.WriteLine("Produto cadastradocom sucesso!");
        }

        public static void ListarProduto()
        {
            List<ProdutoViewModel> listaDeProdutos = produtoRepositorio.ListarProduto();
            foreach (var item in listaDeProdutos)
            {
                Console.WriteLine($"Id: {item.Id} - Nome: {item.Nome} - Descrição: {item.Descricao} - Preço: {item.Preco} - Categoria: {item.Categoria}");
            }
        }
        
         public static ProdutoViewModel BuscarPorId(){
            string id;

            do
            {
            Console.WriteLine("Insira o Id");
            id = Console.ReadLine();

            } while (false);

            ProdutoViewModel idRecuperado = produtoRepositorio.BuscarId(id);
            if (idRecuperado != null)
            {
                return idRecuperado;
            }else{
                Console.WriteLine("Produto não encontrado");
                return null;
            }
        }
    }
}

