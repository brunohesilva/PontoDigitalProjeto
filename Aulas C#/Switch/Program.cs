using System;

namespace Switch {
    class Program {
        static void Main (string[] args) {
            string passeio = "";
            switch (passeio) {
                case "montanha":
                    Console.WriteLine ("Bora escalar!");
                    break;
                case "deserto":
                    Console.WriteLine ("Leva uma água!");
                    break;
                case "floresta":
                    Console.WriteLine ("Vai lá, Tarzan");
                    break;
                default:
                    Console.WriteLine ("Ah, então vamos pro Netflix");
                    break;

            }
        }
    }
}