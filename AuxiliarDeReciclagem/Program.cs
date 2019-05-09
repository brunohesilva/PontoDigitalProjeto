using System;
using System.Collections.Generic;
using AuxiliarDeReciclagem.Interfaces;
using AuxiliarDeReciclagem.Models;

namespace AuxiliarDeReciclagem {
        enum ReciclarEnum : uint {
            VAMOS_RECICLAR,
            SAIR
        }
        enum LixosEnum : uint {
            VIDRO,
            METAL,
            PLASTICO,
            PAPEL,
            INDEFINIDO,
            ORGANICO
        }
    class Program {
        static void Main (string[] args) {
            var opcoesReciclar = new List<string> () {
                "   - 0                          ",
                "   - 1                      "
            };

            bool querSair = false;
            string barraMenu = "===================================";
            string[] itensMenuReciclar = Enum.GetNames (typeof (ReciclarEnum));
            int opcaoReciclarSelecionada = 0;

            do {
                bool reciclarEscolhida = false;
                do {
                    Console.Clear ();
                    System.Console.WriteLine (barraMenu);
                    System.Console.WriteLine ("  \\m/ Auxiliar de Reciclagem \\m/ ");
                    System.Console.WriteLine ("        Escolha uma opção:         ");
                    System.Console.WriteLine (barraMenu);

                    for (int i = 0; i < opcoesReciclar.Count; i++) {
                        string titulo = TratarTituloMenu (itensMenuReciclar[i]);

                        if (opcaoReciclarSelecionada == i) {
                            DestacarOpcao (opcoesReciclar[opcaoReciclarSelecionada].Replace ("-", ">").Replace (i.ToString (), titulo));
                        } else {
                            System.Console.WriteLine (opcoesReciclar[i].Replace (i.ToString (), titulo));
                        }

                        var tecla = Console.ReadKey (true).Key;

                    switch (tecla) {
                        case ConsoleKey.UpArrow:
                            opcaoReciclarSelecionada = opcaoReciclarSelecionada == 0 ? opcaoReciclarSelecionada : --opcaoReciclarSelecionada;
                            break;
                        case ConsoleKey.DownArrow:
                            opcaoReciclarSelecionada = opcaoReciclarSelecionada == opcoesReciclar.Count - 1 ? opcaoReciclarSelecionada : ++opcaoReciclarSelecionada;
                            break;
                        case ConsoleKey.Enter:
                            reciclarEscolhida = true;
                            break;

                        }
                    }
                } while (!reciclarEscolhida);

                switch (opcaoReciclarSelecionada) {
                    case 0:
                        do {
                            ExibirMenuDeLixos ();
                            System.Console.WriteLine ("Digite o código do Lixo para a saber a sua lixeira");
                            int codigo = int.Parse (Console.ReadLine ());
                            var lixo = Candidatos.Lixos[codigo];

                            Type interfaceEncontrada  = lixo.GetType ().GetInterface ("IAmarelo");

                            if (interfaceEncontrada != null){
                                ColocarNoAmarelo ((IAmarelo) lixo);
                            } else {
                               continue; 
                            }

                            System.Console.WriteLine ("Digite o código do Lixo para a saber a sua lixeira");
                            codigo = int.Parse (Console.ReadLine ());
                            lixo = Candidatos.Lixos[codigo];

                            interfaceEncontrada  = lixo.GetType ().GetInterface ("IAzul");

                            if (interfaceEncontrada != null){
                                ColocarNoAzul ((IAzul) lixo);
                            } else {
                               continue; 
                            }

                            System.Console.WriteLine ("Digite o código do Lixo para a saber a sua lixeira");
                            codigo = int.Parse (Console.ReadLine ());
                            lixo = Candidatos.Lixos[codigo];

                            interfaceEncontrada  = lixo.GetType ().GetInterface ("ICinza");

                            if (interfaceEncontrada != null){
                                ColocarNoCinza ((ICinza) lixo);
                            } else {
                               continue; 
                            }

                            System.Console.WriteLine ("Digite o código do Lixo para a saber a sua lixeira");
                            codigo = int.Parse (Console.ReadLine ());
                            lixo = Candidatos.Lixos[codigo];

                            interfaceEncontrada  = lixo.GetType ().GetInterface ("IPreto");

                            if (interfaceEncontrada != null){
                                ColocarNoPreto ((IPreto) lixo);
                            } else {
                               continue; 
                            }

                        } while (!querSair);
                        break;
                }
            } while (!querSair);
        }

        public static bool ColocarNoPreto(IPreto lixo)
        {
            System.Console.WriteLine ("Lixo Orgânico deve ser mandando para a composteira ou é reprentado pela lixeira Preta");
            return true;
        }

        public static bool ColocarNoCinza(ICinza lixo)
        {
            System.Console.WriteLine ("Lixos não definidos são jogados na Lixeira Cinza");
            return true;
        }

        public static bool ColocarNoAzul(IAzul lixo)
        {
           System.Console.WriteLine ("Papel são jogados na Azul");
            return true;
        }

        public static bool ColocarNoAmarelo(IAmarelo lixo)
        {
            System.Console.WriteLine ("Lixos Metalicos são jogados na Lixeira Amarela");
            return true;
        }

        public static string TratarTituloMenu (string titulo) {
            return System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase (titulo.Replace ("_", " ").ToLower ());
        }

        public static void DestacarOpcao (string opcao) {
            Console.BackgroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine (opcao);
            Console.ResetColor ();
        }

        public static void ExibirMenuDeLixos () {
            var lixos = Enum.GetNames (typeof (LixosEnum));
            int codigo = 1;
            string menuLixoBorda = "##############################";
            System.Console.WriteLine (menuLixoBorda);
            System.Console.WriteLine ("#         Opções       #");

            foreach (var lixo in lixos) {
                System.Console.WriteLine ($"  {codigo++}.{TratarTituloMenu(lixo)}");
            }

            System.Console.WriteLine (menuLixoBorda);

        }


    }
}