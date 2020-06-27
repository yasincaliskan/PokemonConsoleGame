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
    }
}
