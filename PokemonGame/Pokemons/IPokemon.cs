using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public interface IPokemon
    {
        double DoAttack();

        void Evolve(Pokemon pokemon);
    }
}
