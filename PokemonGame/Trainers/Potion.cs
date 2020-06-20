using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Potion:Item
    {
        public void UsePotion(Pokemon pokemon)
        {
            pokemon.Health += 20; //health value??
            this.Quantity--;
        }
    }
}
