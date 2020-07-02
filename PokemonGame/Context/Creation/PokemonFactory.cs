using PokemonGame.GameContext.Navigations;
using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Context.Creation
{
    public class PokemonFactory
    {
        static List<Pokemon> allPokemons = DataOperation.LoadPokemons();
        public static Pokemon CreateWildPokemon()
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(0, allPokemons.Count);
            Pokemon wildPokemon = allPokemons[randomNumber];

            return wildPokemon;
        }

        public static Pokemon CreateSpecificPokemon(string pokemonName)
        {
            foreach (var pokemon in allPokemons)
            {
                if(pokemon.name.english == pokemonName)
                {
                    Pokemon specificPokemon = pokemon;
                    return specificPokemon;
                }
            }
            return null;
        }
    }
}
