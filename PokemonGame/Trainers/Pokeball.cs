using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Pokeball:Item
    {
        public Pokemon ThrowTheBall(Pokemon pokemon, Trainer trainer)
        {
            if(pokemon.Health < 25 && pokemon.Health > 0)
            {
                trainer.Pokemons.Add(pokemon);
            }

            this.Quantity--;
            return new Pokemon();
        }
    }
}
