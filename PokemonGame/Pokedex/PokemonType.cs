using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public class PokemonType
    {
        public string name { get; set; }
        public List<string> immunes { get; set; }
        public List<string> weaknesses { get; set; }
        public List<string> strengths { get; set; }

        public PokemonType()
        {

        }

        public static void CompareEffectivenes(Pokemon trainerPokemon, Pokemon opponentPokemon)
        {
            //List<string> trainerPokemonType = trainerPokemon.types;
            //List<string> opponentPokemonType = opponentPokemon.types;
            //foreach (var traPokeType in trainerPokemonType)
            //{

            //    foreach (var oppoPokeType in opponentPokemonType)
            //    {
            //        if ()
            //        {
            //            effectValue = 5;
            //        }
            //        else if (current.strengths.Contains(opponent.name))
            //        {
            //            effectValue = 3;
            //        }
            //        else if (current.weaknesses.Contains(opponent.name))
            //        {
            //            effectValue = -3;
            //        }
            //        else
            //        {
            //            effectValue = 1;
            //        }

            //    }

            //}
        }
    }
}
