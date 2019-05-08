using System.Collections.Generic;

namespace AuxiliarDeReciclagem.Models
{
    public class Candidatos
    {
        public static Dictionary<int, LixosCategoria> Lixos = new Dictionary<int, LixosCategoria> {
            { 1, new Vidro() },
            { 2, new Metal() },
            { 3, new Plastico() },
            { 4, new Papel() },
            { 5, new Indefinido() },
            { 6, new Organico() },
        };
    }
}