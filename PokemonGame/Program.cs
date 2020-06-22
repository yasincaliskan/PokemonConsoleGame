using PokemonGame.GameContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Game game = new Game();

            choice = game.StartGame();

            if(choice == 1)
            {
                game.NewGame();
            }
            else if(choice == 2)
            {
                //Load game
            }

            Console.ReadLine();
        }
    }
}
