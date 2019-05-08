using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models
{
    public class Metal : LixosCategoria, IAmarelo
    {
        public bool JogarNaAmarela()
        {
            System.Console.WriteLine ("Lixos Metalicos são jogados na Lixeira Amarela");
            return true;
        }
    }
}