using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Opponent :Player, IPlayer
    {
        public void ShowRosettes()
        {
            int index = 1;
            foreach (var item in this.Rosettes)
            {
                Console.WriteLine($"{index}. {item.Name}");
                index++;
            }
        }

        public void UsePotion()
        {
            
        }
    }
}
