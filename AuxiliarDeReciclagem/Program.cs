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

                            switch (codigo) {
                                case 1:
                                    

                                    
                                    break;
                                case 2:
                                    break;
                                case 3:
                                    break;
                                case 4:
                                    break;
                                case 5:
                                    break;
                                case 6:
                                    break;
                            }
                        } while (!querSair);
                        break;
                }
            } while (!querSair);
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