using EscolaDeRock.Interfaces;

namespace EscolaDeRock.Models
{
    public class Guitarra : InstrumentoMusical, IMelodia, IHarmonia
    {
        public bool TocarAcordes()
        {
            System.Console.WriteLine("Mantendo ritmo do Contrabaixo");
            return true;
        }

        public bool TocarSolo()
        {
            System.Console.WriteLine("Tocando acordes do Contrabaixo");
            return true;
        }
    }
}