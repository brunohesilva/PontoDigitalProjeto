using System;

namespace ArrayAirLines
{
    class Passageiro
    {       
        string nome;
        int numeroPassagem {get; set;}
        DateTime data;

        public void setNome(string nome) {
            this.nome = nome;
        }

        public string getNome() {
            return this.nome;
        }

        // public void setPassagem(int numeroPassagem) {
        //     this.numeroPassagem = numeroPassagem;
        // }

        // public int getPassagem() {
        //     return this.numeroPassagem;
        // }
    }
}
