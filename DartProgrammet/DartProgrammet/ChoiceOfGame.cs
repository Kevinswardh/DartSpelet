using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DartProgrammet
{
    internal class MultiPlayer
    {
        public void Spela()
        {
            Console.Clear();
            Players.HowManyPlayers();
            Players.AddPlayers();
            Game.gamestart();
           


        }
    }
    internal class SinglePlayer
    {
        public void Spela()
        {
            Console.Clear();
            Players.AddComputer();
            Players.AddSinglePlayer();
            Players.AddPlayers();
            Game.gamestart();

        }
    }
}
