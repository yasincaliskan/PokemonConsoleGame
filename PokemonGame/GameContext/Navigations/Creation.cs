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
            List<PokemonType> allPokemonTypes = DataOperation.LoadPokemonType();
            List<Pokemon> allPokemons = DataOperation.LoadPokemons();

            return allPokemons;
        }

        public static List<Pokemon> StartingPokemons()
        {
            List<Pokemon> InitialPokemons = DataOperation.LoadInitialPokemons();
            
            return InitialPokemons;
        }


        public static List<Arena> CreateArenas()
        {
            List<Arena> arenaList = new List<Arena>();
            Arena townArena = new Arena("PaletteTown");
            Arena champArena = new Arena("ChampionArena");

            arenaList.Add(townArena);
            arenaList.Add(champArena);
            return arenaList;
        }

        public static List<Player> CreateOpponents()
        {
            List<Player> opponentList = new List<Player>();
            Player ashKetchum = new Opponent("Ash Ketchum");
            Player misty = new Opponent("Misty");
            Player brock = new Opponent("Brock");

            opponentList.Add(ashKetchum);
            opponentList.Add(misty);
            opponentList.Add(brock);

            return opponentList;
        }
    }
}
