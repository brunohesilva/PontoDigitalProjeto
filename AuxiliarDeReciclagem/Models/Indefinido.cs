using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models
{
    public class Indefinido : LixosCategoria, ICinza
    {
        public bool JogarNaCinza()
        {
            System.Console.WriteLine ("Lixos não definidos são jogados na Lixeira Cinza");
            return true;
        }
    }
}