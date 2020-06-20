using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Trainer
    {
        public string Nickname { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public List<Item> Items { get; set; }

        public Trainer(string nickname)
        {
            this.Nickname = nickname;
            this.Items.Add(new Pokeball());
            this.Items.Add(new Potion());
        }
    }
}
