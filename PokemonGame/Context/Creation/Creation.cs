using PokemonGame.GameContext.Navigations;
using PokemonGame.Places;
using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext
{
    public static class Creation
    {
        public static List<Pokemon> StartingObjects()
        {
            //List<PokemonType> allPokemonTypes = DataOperation.LoadPokemonType();
            List<Pokemon> allPokemons = DataOperation.LoadPokemons();

            return allPokemons;
        }

        public static List<Pokemon> StartingPokemons()
        {
            List<Pokemon> InitialPokemons = DataOperation.LoadInitialPokemons();
            
            return InitialPokemons;
        }

        public static List<string> ArenaNames()
        {
            return new List<string>() {"Palette Town", "Champion GYM"};
        }

        public static List<string> PlayerNames()
        {
            return new List<string>() { "Ash Ketchum", "Misty", "Brock" };
        }
    }
}
