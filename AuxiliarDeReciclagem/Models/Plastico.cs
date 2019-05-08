using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models {
    public class Plastico : LixosCategoria, IVermelho
    {
        public bool JogarNoVermelho()
        {
            System.Console.WriteLine ("Plástico são jogados na Lixeira Vermelha");
            return true;
        }
    }
}