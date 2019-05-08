using AuxiliarDeReciclagem.Interfaces;

namespace AuxiliarDeReciclagem.Models {
    public class Organico : LixosCategoria, IPreto
    {
        public bool JogarNoPreta()
        {
            System.Console.WriteLine ("Lixo Orgânico deve ser mandando para a composteira ou é reprentado pela lixeira Preta");
            return true;
        }
    }
}