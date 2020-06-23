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
            Game game = new Game();

            game.StartGame();

            Console.ReadLine();
        }
    }
}
