using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Player:IPlayer
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
            foreach (var item in this.Rosettes)
            {
                Console.WriteLine($"-> {item.Name} - [{item.Arena}]");
                
            }
        }

        public void ShowPokemons()
        {
            foreach (var item in this.Pokemons)
            {
                Console.WriteLine($"-> {item.name.english} - HP: {item.HP}");
            }
        }
    }
}
