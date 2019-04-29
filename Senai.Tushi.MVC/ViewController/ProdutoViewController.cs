using System;

namespace Senai.Tushi.MVC.ViewController
{
    public class ProdutoViewController
    {
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

            } while (true);

            do
            {
                Console.WriteLine("Descreva o Produto");
                descricao = Console.ReadLine();
            } while (true);
        }
    }
}