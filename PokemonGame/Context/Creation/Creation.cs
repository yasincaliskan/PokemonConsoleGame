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

            List<Player> opponentPlayer = CreateOpponents();
            townArena.Opponents.Add(opponentPlayer[0]);
            champArena.Opponents.Add(opponentPlayer[1]);
            champArena.Opponents.Add(opponentPlayer[2]);

            List<Rosette> rosettes = CreateRosettes();
            townArena.Rosette = rosettes[0];
            champArena.Rosette = rosettes[1];
            
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

        public static List<Rosette> CreateRosettes()
        {
            List<Rosette> rosettes = new List<Rosette>();
            Rosette ashRosette = new Rosette("Star");
            Rosette mistyRosette = new Rosette("Ocean");
            Rosette brockRosette = new Rosette("Rock");

            rosettes.Add(ashRosette);
            rosettes.Add(mistyRosette);
            rosettes.Add(brockRosette);

            return rosettes;
        }
    }
}
