using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext
{
    public static class Creation
    {
        public static List<Pokemon> StartingPokemons()
        {
            List<Pokemon> InitialPokemons = new List<Pokemon>();
            Pokemon initialBulbasaur = new Pokemon("Bulbasaur");
            Pokemon initialSquirtle = new Pokemon("Squirtle");
            Pokemon initialCharmander = new Pokemon("Charmander");
            InitialPokemons.Add(initialBulbasaur);
            InitialPokemons.Add(initialSquirtle);
            InitialPokemons.Add(initialCharmander);

            return InitialPokemons;
        }

        public static List<PokemonType> CreateTypes(
            string name,
            List<PokemonType> AdvantangeAttack,
            List<PokemonType> DisadvantangeAttack,
            List<PokemonType> AdvatageDefense,
            List<PokemonType> DisadvatangeDefense
            )
        {
            List<PokemonType> PokemonTypes = new List<PokemonType>();
            PokemonType pokemonType = new PokemonType(name, AdvantangeAttack, DisadvantangeAttack, AdvatageDefense, DisadvatangeDefense);
            PokemonTypes.Add(pokemonType);
            return PokemonTypes;
        }

        public static List<Pokemon> CreateWildPokemons()
        {
            List<Pokemon> wildPokemons = new List<Pokemon>();
            Pokemon Pidgey = new Pokemon("Pidgey");
            Pokemon Rattata = new Pokemon("Rattata");

            wildPokemons.Add(Pidgey);
            wildPokemons.Add(Rattata);

            return wildPokemons;
        }
    }
}
