// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace DartProgrammet
{
    class Program
    {
        public static void Main(string[] args)
        {
            string S = "";
            S += "\\";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("               /l--------------------l" + S);
            Console.WriteLine("              / l                    l " + S);
            Console.Write("             /  l");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("    Dart Spelet     ");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("l  " + S);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("            /   l                    l   " + S);
            Console.WriteLine("           /____l--------------------l____" + S);
            Console.WriteLine("");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("                        Regler");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("          ___________________________________");
            Console.WriteLine("          l     Dart spelet går ut på att    l ");
            Console.WriteLine("          l   välja ett nummer mellan 1-20   l ");
            Console.WriteLine("          l        Som man siktar mot        l ");
            Console.WriteLine("          l     Desto högre man väljer       l ");
            Console.WriteLine("          l   desto högre är risken för att  l");
            Console.WriteLine("          l   missa, först till 301 vinner   l");
            Console.WriteLine("          ------------------------------------ ");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("_________________________     _________________________");
            Console.WriteLine("l      Singleplayer     l     l       Multiplayer     l ");
            Console.WriteLine("-------------------------     -------------------------");
            Console.WriteLine("          [1}                             [2]");
            Console.WriteLine("");
            firstChoice();
            void firstChoice()
            {
                string huvudmeny = Console.ReadLine();
                huvudmeny.ToLower();
                switch (huvudmeny)
                {
                    case "1":
                    case "single player":
                    case "singleplayer":
                        SinglePlayer Dart_spelet_Single = new SinglePlayer();
                        Dart_spelet_Single.Spela();
                        break;

                    case "2":
                    case "multi player":
                    case "multiplayer":
                        MultiPlayer Dart_spelet_Multi = new MultiPlayer();
                        Dart_spelet_Multi.Spela();
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("                          Wrong Input");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Mata in antigen 1/2 eller skriv in Single Player eller Multi Player");
                        break;
                }
                if (huvudmeny != "1" && huvudmeny != "singeplayer" && huvudmeny != "single player" && huvudmeny != "2" && huvudmeny != "mutli player" && huvudmeny != "multiplayer")
                {
                    firstChoice();
                }
            }
        }
    }
}