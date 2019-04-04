using System;

namespace Ex6Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // int formula;
            // int contador;
            // int numero;

            // Console.Write("Digite o Numero para Obter a Taboada : ");
            // numero = Int32.Parse(Console.ReadLine());

        
            // for (contador = 1; contador <= 10; ++contador)
            // {
            //     formula =  numero * contador;
            //     Console.WriteLine(numero + " X " + contador + " = " + formula);
                
            // }


            int cont = 0;
            bool repetir = true;
            
            while(repetir){
            Console.WriteLine("Insira o número da tabuada");
            int num = int.Parse(Console.ReadLine());
            while (cont <= 10) {
                Console.WriteLine(num+"x"+cont+"="+num*cont);
                cont++;
                }
                Console.WriteLine("repetir?");
                string resposta = Console.ReadLine();
                repetir = resposta.Equals("sim")? true : false;
            }
        }
    }
}
