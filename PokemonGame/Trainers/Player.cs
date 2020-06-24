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
        public int Pokeballs { get; set; }
        public int Potions { get; set; }
        public List<Rosette> Rosettes { get; set; }

        public Player()
        {
            this.Pokemons = new List<Pokemon>();
        }
        public Player(string nickname)
        {
            this.Nickname = nickname;
            this.Pokemons = new List<Pokemon>();
            this.Pokeballs = 3;
            this.Potions = 2;
        }
    }
}
