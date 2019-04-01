using System;

namespace Aulas_C_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Calculando a media");
            float nota1=9;
            float nota2=10;
            float nota3=5;

            float soma;
            
            soma = nota1 + nota2 + nota3;
            float media = soma/3;
            Console.WriteLine("A soma das notas é: "+soma+" e a média é: "+media);
        }
    }
}
