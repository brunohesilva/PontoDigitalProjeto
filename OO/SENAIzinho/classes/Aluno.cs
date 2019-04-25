using System;

namespace SENAIzinho
{
    public class Aluno
    {
       public string Nome {get; set;}
        public DateTime DataNascimento {get; set;}
        public string Curso {get; set;}
        public int NumeroSala {get; set;}

        // public Aluno(){}
        public Aluno(string nome) {
           this.Nome = nome; 
        }

        // public Aluno(string nome, DateTime DataNascimento) {

        // }
    }
}