using System;

namespace Media2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            // // string[] nomes = new string[10];
            // // string[] sobrenome = new string[10];
            // // float[] n1 = new float[10];
            // // float[] n2 = new float[10];
            // // float[] soma = new float[10];
            
            // // Console.WriteLine("Bem vindo ao calcule sua media 2.0");
            // // Console.WriteLine("----------------------------------");
            
            // // for (int i = 0; i < 10; i++)
            // // {
                
            // // Console.WriteLine("Insira seu Nome");
            // // nomes[i] =  Console.ReadLine();
            // // Console.WriteLine("Insira sue Sobrenome");
            // // sobrenome[i] = Console.ReadLine();
            // // Console.WriteLine("Insira sue primeira Nota");
            // // n1[i] = float.Parse(Console.ReadLine());
            // // Console.WriteLine("Insira sue segunda Nota");
            // // n2[i] = float.Parse(Console.ReadLine());

            // }
            Console.WriteLine("Relatório Escolar");

            string[] nomes = new string[2];
            string[] sobreNomes = new string[2];
            float[] notas1 = new float[2];
            float[] notas2 = new float[2];
            float[] medias = new float[2];
            string[] situacao = new string[2];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Digite o nome do aluno");
                nomes[i] = Console.ReadLine();

                Console.WriteLine("Digite o sobrenome");
                sobreNomes[i] = Console.ReadLine();

                Console.WriteLine("Digite a primeira nota");
                notas1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a segunda nota");
                notas2[i] = int.Parse(Console.ReadLine());

                medias [i] = (notas1[i]+notas2[1])/2;

                if (medias[i]>=50) {
                  situacao[i] = "Aprovado"; 
                }else{
                    situacao[i] = "Reprovado";
                }
            }

            for (int i = 0; i > 2; i++)
            {
                
            }
        }
    }
}
