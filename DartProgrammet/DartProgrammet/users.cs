using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartProgrammet
{
    internal class Players
    {

        private static int hurmångaspelare;


        public static void HowManyPlayers()
        {
            Console.WriteLine("            __________________________________");
            Console.WriteLine("            l   Hur Många är ni som spelar?  l ");
            Console.WriteLine("            ----------------------------------");
            hurmångaspelare = Convert.ToInt32(Console.ReadLine());
        }
        public static void AddPlayers()
        {
            Console.Clear();
            Console.WriteLine("      vad god och ange era namn för " + hurmångaspelare + " antal spelare");
            int i = 0;

            for (i = 1; i <= hurmångaspelare; i++)
            {

                Console.WriteLine("            __________________________________");
                Console.WriteLine("            l    Ange namn för spelare " + i + "     l");
                Console.WriteLine("            ----------------------------------");
                Game.AddPlayerToList();
            }

        }
        public static void AddComputer()
        {
            Game.AddComputerToList();
        }
        public static void AddSinglePlayer()
        {
            hurmångaspelare = 1;
        }


    }           
}

                  




         
                        
                       
                    
     



            
   
