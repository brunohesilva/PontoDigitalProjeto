using System;

namespace DesafioPizzaria {
        public class Produto {
        // static Produto[] arrayDeProduto = new Produto[1000];
        // static int contadorProduto = 0;
        // public int IdProduto { get; set; }
        // public string NomeProduto { get; set; }
        // public string Descricao { get; set; }
        // public double Preco { get; set; }
        // public string Categoria { get; set; }
        // public DateTime DataCriacaoProduto { get; set; }

        // public static void InserirProduto () {
        //     string nomeProduto;
        //     string descricao;
        //     double preco;
        //     string categoria;

        //     Console.WriteLine ("Digite o nome do Produto:");
        //     nomeProduto = Console.ReadLine ();

        //     Console.WriteLine ("Faça uma descrição do Produto");
        //     descricao = Console.ReadLine ();

        //     Console.WriteLine ("Colque um Preço no Produto");
        //     preco = double.Parse(Console.ReadLine());

        //     Console.WriteLine ("Defina  a como a categoria como Pizza ou Bebida");
        //     categoria = Console.ReadLine();

        //     arrayDeProduto[contadorProduto] = new Produto ();
        //     arrayDeProduto[contadorProduto].IdProduto = contadorProduto + 1;
        //     arrayDeProduto[contadorProduto].NomeProduto = nomeProduto;
        //     arrayDeProduto[contadorProduto].Descricao = descricao;
        //     arrayDeProduto[contadorProduto].Preco = preco;
        //     arrayDeProduto[contadorProduto].Categoria = categoria;
        //     arrayDeProduto[contadorProduto].DataCriacaoProduto = DateTime.Now;
        //     contadorProduto++;       
        // }

        // public static void ListarProduto () {
        //     foreach (var itemProduto in arrayDeProduto) {
        //         if (itemProduto == null) {
        //            break; 
        //         }
        //         Console.WriteLine ($"Id: {itemProduto.IdProduto} Nome: {itemProduto.NomeProduto} Preço: {itemProduto.Preco}");
        //     }
        // }

        // public static void BuscarID () {

        //     Console.WriteLine ("Digite o ID do Produto");
        //     string idProduto = Console.ReadLine();

        //     foreach (var itemProduto in arrayDeProduto) {
        //         if (itemProduto == null) {
        //             break;
        //         }
        //         if(idProduto.Equals(itemProduto.IdProduto))
        //     }
        // }

        static Produto[] arrayDeProdutos = new Produto[1000];
        static int contador = 0;
        public int Id {get;set;}
        public string Nome {get;set;}
        public string Descricao {get;set;}
        public float Preco {get;set;}
        public string Categoria{get;set;}
        public DateTime DataCriacao{get;set;}

       public Produto(string nome, string desc, float preco, string categoria){

           this.Nome = nome;
           this.Descricao = desc;
           this.Preco = preco;
           this.Categoria = categoria;
           this.Id = contador +1;
           this.DataCriacao = DateTime.Now;

        }
    
        public static void CadastrarProduto(){
            string nome;
            string desc;
            float preco;
            string categoria;

            Console.WriteLine("Digite o Nome do Produto:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite a Descrição:");
            desc = Console.ReadLine();

            Console.WriteLine("Digite o preço");
            preco = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a Categoria do Produto");
            categoria = Console.ReadLine();

            Produto p = new Produto(nome, desc, preco, categoria);

            arrayDeProdutos[contador] = p;

            contador++;
            

        }
        public static void ListarProduto(){
            foreach (var item in arrayDeProdutos)
            {
                if (item == null)
                {
                    break;
                }

                Console.WriteLine($"Produto id: {item.Id} - Nome: {item.Nome} - Preço: {item.Preco}");
            }
        }

        public static void BuscaPorId(){
            Console.WriteLine("Digite o ID do Produto");
            int idProduto = int.Parse(Console.ReadLine());

            foreach (var item in arrayDeProdutos)
            {
                if(item == null){
                    break;
                }
                if(idProduto.Equals(item.Id)){
                    Console.WriteLine($"Produto Localizado");
                    Console.WriteLine($"ID - {item.Id}, nome: {item.Nome}");;
                }
            }

        }
    }
}