using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models {
    public class Papel : LixosCategoria, IAzul {
        public bool JogarNaAzul () {
            System.Console.WriteLine ("Papel são jogados na Azul");
            return true;
        }
    }
}