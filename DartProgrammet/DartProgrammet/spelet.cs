using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartProgrammet
{
    internal class Game
    {
        private static List<string> players = new List<string>();
        private static List<int> score = new List<int>();
        private static int currentscore;
        private static int arrow1;
        private static int arrow2;
        private static int arrow3;
        private static int arrow1value { get; set; }
        private static int arrow2value { get; set; }
        private static int arrow3value { get; set; }
        private static int maxscore = 301;
        private static class Globals8
        {
            private static int? globalInt8 = default(int?);
            public static int? GlobalInt8
            {
                get { return globalInt8; }
                set { globalInt8 = value; }
            }
        }
        public static void AddPlayerToList()
        {
            string skapaspelare = Console.ReadLine();
            string ny = skapaspelare.First().ToString().ToUpper() + String.Join("", skapaspelare.Skip(1));
            players.Add(ny);
            score.Add(0);
            Console.Clear();
        }
        public static void AddComputerToList()
        {
            Random randomBot = new Random();
            int RandBotName = randomBot.Next(1, 5);
            if (RandBotName == 1)
            {
                players.Add("BOT_Alfred");
                score.Add(0);
                Console.Clear();
            }
            else if (RandBotName == 2)
            {
                players.Add("BOT_Hank");
                score.Add(0);
                Console.Clear();
            }
            else if (RandBotName == 3)
            {
                players.Add("BOT_Fanny");
                score.Add(0);
                Console.Clear();
            }
            else if(RandBotName == 4)
            {
                players.Add("BOT_Kimmy");
                score.Add(0);
                Console.Clear();
            }
            else if (RandBotName == 5)
            {
                players.Add("BOT_Malin");
                score.Add(0);
                Console.Clear();
            }

        }
        private static void printaspelare()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("                  ** Current players **");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < players.Count; i++)
            {

            Console.WriteLine("Totala Missar: 0     Spelare: " + players[i] + " Score: " + score[i]);
            
            }
        }
        private static void arrowone()
        {
                arrow1 = Convert.ToInt32(Console.ReadLine());
        }
        private static void arrowtwo()
        {
                arrow2 = Convert.ToInt32(Console.ReadLine());
        }
        private static void arrowtree()
        {
                arrow3 = Convert.ToInt32(Console.ReadLine());
        }
        public static void gamestart()
        {


            for (int i = 0; i < 999; i++)
            {

                foreach (var item in players)
                {
                   

                    int listNo = players.IndexOf(item);
                    for (int j = 0; j < players.Count; j++)
                    {

                        Console.WriteLine(score[j]);

                    }

                    reset();
                    void reset()
                    {

                        printaspelare();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"               {item}'s Tur att kasta Score: " + score[listNo]);
                        currentscore = score[listNo];
                        arrow1value = currentscore;
                       
                        Console.WriteLine("");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"                         {item}");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("                              ");
                        Console.WriteLine("                        [5][20][1]");
                        Console.WriteLine("                    [12] \\   |   /[18]");
                        Console.WriteLine("                  [9]     \\  |  /    [4]");
                        Console.WriteLine("                [14]       \\ | /       [13]");
                        Console.WriteLine("                [11]---------|----------[6]");
                        Console.WriteLine("                [8]        / | \\       [10]");
                        Console.WriteLine("                  [16]    /  |  \\     [15]");
                        Console.WriteLine("                     [7] /   |   \\ [2]");
                        Console.WriteLine("                        [19][3][17]");
                        Console.WriteLine("                          ");
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("--------------------------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("   Sikta & Kasta genom att mata in valfri siffra på tavlan");
                        Console.WriteLine("");
                        Console.WriteLine("");
                        if (item == "BOT_Alfred" || item == "BOT_Hank" || item == "BOT_Fanny" || item == "BOT_Kimmy" || item == "BOT_Malin")
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("Bot is playing...");
                            Console.ForegroundColor = ConsoleColor.White;
                            
                        }
                        Console.WriteLine("Kast ett:");
                        if (item == "BOT_Alfred" || item == "BOT_Hank" || item == "BOT_Fanny" || item == "BOT_Kimmy" || item == "BOT_Malin")
                        {
                            if (currentscore >= 280 && currentscore != 300)
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 7);
                                    arrow1 = RandomBotNummer;
                                }
                            }
                            else if(currentscore == 300)
                            {
                                arrow1 = 1;
                            }
                            else
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 10);
                                    arrow1 = RandomBotNummer;

                                }
                                else if (botchance > 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(10, 20);
                                    arrow1 = RandomBotNummer;

                                }
                            }
                        }
                        else
                        {
                            arrowone();
                        }

                        if (arrow1 > 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("                   Fel nummer");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            reset();
                        }
                        
     


                        if (arrow1 == 20)                                                       // arrow1 20       har gjort if statments medsols. börjar på 20.
                        {

                            Random rand = new Random();
                            int chance = rand.Next(101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) 
                            {   
                                arrow1value = currentscore + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance !<= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance !<= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 1;
                                Console.WriteLine("Du träffa 1");
                            }

                            else if (chance !<= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance !<= 90 && chance <= 101)
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }


                        }
                        else if (arrow1 == 1)                                                       // arrow1 1
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow1value = currentscore + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                              
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                             
                                Console.WriteLine("Du Missade.");
                            }




                        }
                        else if (arrow1 == 18)                                                       // arrow1 18
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;

                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 4)                                                       // arrow1 4
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                              
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 13)                                                       // arrow1 13
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 6)                                                       // arrow1 6
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                               
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 10)                                                       // arrow1 10
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 15)                                                       // arrow1 15
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow1value = currentscore + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 2)                                                       // arrow1 2
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 17)                                                       // arrow1 17
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 3)                                                       // arrow1 3
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 19)                                                       // arrow1 19
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        else if (arrow1 == 7)                                                       // arrow1 7
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 16)                                                       // arrow1 16
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 8)                                                       // arrow1 8
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 11)                                                       // arrow1 11
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 14)                                                       // arrow1 14
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 9)                                                       // arrow1 9
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 12)                                                       // arrow1 12
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow1 == 5)                                                       // arrow1 5
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow1value = currentscore + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow1value = currentscore + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow1value = currentscore + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow1value = currentscore + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        if (score[listNo] == maxscore)
                        {
                            Console.Clear();
                            Console.WriteLine($"Winner is {item}");
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        if (arrow1 > 20)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("                   Fel nummer");
                            Console.ForegroundColor = ConsoleColor.White;
                            Thread.Sleep(3000);
                            Console.Clear();
                            reset();
                        }
                        Console.WriteLine("Kast två:");
                        if (item == "BOT_Alfred" || item == "BOT_Hank" || item == "BOT_Fanny" || item == "BOT_Kimmy" || item == "BOT_Malin")
                        {
                            if (currentscore >= 280 && currentscore != 300)
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 7);
                                    arrow2 = RandomBotNummer;
                                }
                            }
                            else if (currentscore == 300)
                            {
                                arrow2 = 0;
                            }
                            else
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 10);
                                    arrow2 = RandomBotNummer;

                                }
                                else if (botchance > 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(10, 20);
                                    arrow2 = RandomBotNummer;

                                }
                            }
                        }
                        else
                        {
                            arrowtwo();
                        }
                        arrow2value = arrow1value;


                        if (arrow2 == 20)                                                       // arrow2 20       har gjort if statments medsols. börjar på 20.
                        {

                            Random rand = new Random();
                            int chance = rand.Next(101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow2value = arrow1value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 1;
                                Console.WriteLine("Du träffa 1");
                            }

                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }


                        }
                        else if (arrow2 == 1)                                                       // arrow1 2
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow2value = arrow1value + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }




                        }
                        else if (arrow2 == 18)                                                       // arrow2 18
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;

                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 4)                                                       // arrow2 4
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 13)                                                       // arrow2 13
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 6)                                                       // arrow2 6
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 10)                                                       // arrow2 10
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 15)                                                       // arrow2 15
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow2value = arrow1value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 2)                                                       // arrow2 2
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 17)                                                       // arrow2 17
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 2;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 3)                                                       // arrow2 3
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 19)                                                       // arrow2 19
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        else if (arrow2 == 7)                                                       // arrow2 7
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 16)                                                       // arrow2 16
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 8)                                                       // arrow2 8
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 11)                                                       // arrow2 11
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 14)                                                       // arrow2 14
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 9)                                                       // arrow2 9
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 12)                                                       // arrow2 12
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow2 == 5)                                                       // arrow2 5
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow2value = arrow1value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow2value = arrow1value + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow2value = arrow1value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow2value = arrow1value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        Console.WriteLine("Kast tre:");
                        if (item == "BOT_Alfred" || item == "BOT_Hank" || item == "BOT_Fanny" || item == "BOT_Kimmy" || item == "BOT_Malin")
                        {
                            if (currentscore >= 280 && currentscore != 300)
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 7);
                                    arrow3 = RandomBotNummer;
                                }
                            }
                            else if (currentscore == 300)
                            {
                                arrow3 = 0;
                            }
                            else
                            {
                                Thread.Sleep(1000);
                                Random BotPrio = new Random();
                                int botchance = BotPrio.Next(1, 101);
                                if (botchance < 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(1, 10);
                                    arrow3 = RandomBotNummer;

                                }
                                else if (botchance > 40)
                                {
                                    Random randbotnum = new Random();
                                    int RandomBotNummer = randbotnum.Next(10, 20);
                                    arrow3 = RandomBotNummer;

                                }
                            }
                        }
                        else
                        {
                            arrowtree();
                        }
                        arrow3value = arrow2value;

                        if (arrow3 == 20)                                                       // arrow3 20       har gjort if statments medsols. börjar på 20.
                        {

                            Random rand = new Random();
                            int chance = rand.Next(101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow3value = arrow2value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 1;
                                Console.WriteLine("Du träffa 1");
                            }

                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }


                        }
                        else if (arrow3 == 1)                                                       // arrow3 2
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow3value = arrow2value + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }




                        }
                        else if (arrow3 == 18)                                                       // arrow3 18
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;

                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 1;
                                Console.WriteLine("Du träffa 1");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                         
                        }
                        else if (arrow3 == 4)                                                       // arrow3 4
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 18;
                                Console.WriteLine("Du träffa 18");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 13)                                                       // arrow3 13
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 4;
                                Console.WriteLine("Du träffa 4");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 6)                                                       // arrow3 6
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 13;
                                Console.WriteLine("Du träffa 13");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 10)                                                       // arrow3 10
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 6;
                                Console.WriteLine("Du träffa 6");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 15)                                                       // arrow3 15
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40)
                            {
                                arrow3value = arrow2value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 10;
                                Console.WriteLine("Du träffa 10");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 2)                                                       // arrow3 2
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 15;
                                Console.WriteLine("Du träffa 15");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 17)                                                       // arrow3 17
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 2;
                                Console.WriteLine("Du träffa 2");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 3)                                                       // arrow3 3
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 17;
                                Console.WriteLine("Du träffa 17");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 19)                                                       // arrow3 19
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 3;
                                Console.WriteLine("Du träffa 3");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        else if (arrow3 == 7)                                                       // arrow3 7
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 19;
                                Console.WriteLine("Du träffa 19");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 16)                                                       // arrow3 16
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 7;
                                Console.WriteLine("Du träffa 7");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 8)                                                       // arrow3 8
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 16;
                                Console.WriteLine("Du träffa 16");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 11)                                                       // arrow3 11
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 8;
                                Console.WriteLine("Du träffa 8");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 14)                                                       // arrow3 14
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 11;
                                Console.WriteLine("Du träffa 11");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 9)                                                       // arrow3 9
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 14;
                                Console.WriteLine("Du träffa 14");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 12;
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 12)                                                       // arrow3 12
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 9;
                                Console.WriteLine("Du träffa 9");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }

                        }
                        else if (arrow3 == 5)                                                       // arrow3 5
                        {
                            Random rand = new Random();
                            int chance = rand.Next(1, 101);
                            Random randnum = new Random();
                            int randomnum = randnum.Next(1, 20);
                            Globals8.GlobalInt8 = Globals8.GlobalInt8.HasValue ? Globals8.GlobalInt8 : randomnum;
                            if (chance <= 40) //  25%
                            {
                                arrow3value = arrow2value + 5;
                                Console.WriteLine("Du träffa 5");
                            }
                            else if (chance! <= 40 && chance <= 60)
                            {
                                arrow3value = arrow2value + 12;
                                Console.WriteLine("Du träffa 12");
                            }
                            else if (chance! <= 60 && chance <= 80)
                            {
                                arrow3value = arrow2value + 20;
                                Console.WriteLine("Du träffa 20");
                            }
                            else if (chance! <= 80 && chance <= 90)
                            {
                                arrow3value = arrow2value + randomnum;
                                Console.WriteLine($"Du träffa {randomnum}");
                            }
                            else if (chance! <= 90 && chance <= 101)
                            {
                                Console.WriteLine("Du Missade.");
                            }
                            else
                            {
                                Console.WriteLine("Du Missade.");
                            }
                        }
                        if (arrow3value > maxscore)
                        {
                            score.Insert(listNo, currentscore);
                            score.RemoveAt(listNo + 1);
                        }
                        else if (arrow3value < maxscore)
                        {
                            score.Insert(listNo, arrow3value);
                            score.RemoveAt(listNo + 1);
                        }
                        else if (arrow3value == maxscore)
                        {
                            score.Insert(listNo, arrow3value);
                            score.RemoveAt(listNo + 1);
                            i = 999;
                            Console.Clear();
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("                  ** Game Finished **");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write($"                    Winner is ");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write(item);
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.ForegroundColor = ConsoleColor.White;
                            for (int i = 0; i < players.Count; i++)
                            {

                                Console.WriteLine("Totala Missar: 0     Spelare: " + players[i] + " Score: " + score[i]);

                            }
                            Console.ReadLine();
                            Environment.Exit(0);
                        }
                        Console.WriteLine("Mata in valfritt nummer eller bokstav för att nästa spelare ska kasta");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }

            }
        }
    }
}

                  




         
                        
                       
                    
     



            
   
