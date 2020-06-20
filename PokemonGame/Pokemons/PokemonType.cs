using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public class PokemonType
    {
        public string Name { get; set; }
        public List<PokemonType> AdvantageAttack { get; set; }
        public List<PokemonType> DisadvantageAttack { get; set; }
        public List<PokemonType> AdvantageDefense { get; set; }
        public List<PokemonType> DisadvantageDefense { get; set; }

    }
}
