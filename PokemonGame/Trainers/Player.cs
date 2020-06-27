using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Player
    {
        public string Nickname { get; set; }
        public List<Pokemon> Pokemons { get; set; }
    
        public List<Rosette> Rosettes { get; set; }

        public Player()
        {
            this.Pokemons = new List<Pokemon>();
            this.Rosettes = new List<Rosette>();
        }
        public Player(string nickname)
        {
            this.Nickname = nickname;
            this.Pokemons = new List<Pokemon>();
            this.Rosettes = new List<Rosette>();

        }
        public void ShowRosettes()
        {
            int index = 1;
            foreach (var item in this.Rosettes)
            {
                Console.WriteLine($"{index}. {item.Name} - [{item.Arena}]");
                index++;
            }
        }
    }
}
