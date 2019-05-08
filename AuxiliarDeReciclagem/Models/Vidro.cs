using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models {
    public class Vidro : LixosCategoria, IVerde
    {
        public bool JogarNaVerde()
        {
            System.Console.WriteLine ("Vidros são jogados na Lixeira Verde");
            return true;
        }
    }
}