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

        public Trainer()
        {
            this.Pokemons = new List<Pokemon>();
            //Pokeball pokeballs = new Pokeball();
            //Potion potions = new Potion();

            //this.Items.Add(pokeballs);
            //this.Items.Add(potions);
        }
        public Trainer(string nickname)
        {
            this.Nickname = nickname;
            this.Pokemons = new List<Pokemon>();
            //Pokeball pokeballs = new Pokeball();
            //Potion potions = new Potion();
            //this.Items.Add(pokeballs);
            //this.Items.Add(potions);
        }
    }
}
