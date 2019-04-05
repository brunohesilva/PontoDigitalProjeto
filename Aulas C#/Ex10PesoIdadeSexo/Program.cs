using System;

namespace Ex10PesoIdadeSexo
{
    class Program
    {
        static void Main(string[] args)
        {
            int masculino = 0;
            int feminino = 0;
            float masculinoPeso = 0;
            float femininoPeso = 0;
            int masculinoIdade = 0;
            int femininoIdade = 0;
            string sexo;

            for (int i = 0; i < 2; i++) {
                do {

                    Console.WriteLine ("Digite seu sexo [M] ou [F]:");
                    sexo = Console.ReadLine ().ToUpper();
                    if (sexo != ("M") && sexo != ("F")) {
                        Console.WriteLine ("Valor inválido");
                    } 

                } while (!sexo.Equals ("M") && !sexo.Equals ("F"));

                Console.WriteLine ("Digite sua Idade:");
                int idade = int.Parse (Console.ReadLine ());

                Console.WriteLine ("Digite seu peso:");
                float peso = float.Parse (Console.ReadLine ());

                 if(sexo.Equals("M")){
                    masculino++;
                    masculinoIdade += idade;
                    masculinoPeso += peso;
                }else{
                   feminino++;
                   femininoIdade += idade;
                   femininoPeso += peso; 
                }
            } //fim for
            if(masculino != 0){
            float mediaPesoMasculino = masculinoPeso/masculino;
            float mediaIdadeMasculino = masculinoIdade/masculino;
            Console.WriteLine("Quantidade de Masculino {0}, Média Idade {1}, Média Peso {2}", masculino,mediaIdadeMasculino,mediaPesoMasculino);
            }else{
            Console.WriteLine("Nenhum Homem cadastrado");
            }
            if(feminino != 0){
            float mediaPesofeminino = femininoPeso/feminino;
            float mediaIdadeFeminino = femininoIdade/feminino;
            Console.WriteLine("Quantidade de Feminino {0}, Média Idade {1}, Média Peso {2}", feminino,mediaIdadeFeminino,mediaPesofeminino);
            }else{
            Console.WriteLine("Nenhuma Mulher cadastrada");
            }
        }
    }
}
