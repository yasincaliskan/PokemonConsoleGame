using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public class Types
    {
        public string Name { get; set; }
        public List<Types> AdvantageAttack { get; set; }
        public List<Types> DisadvantageAttack { get; set; }
        public List<Types> AdvantageDefense { get; set; }
        public List<Types> DisadvantageDefense { get; set; }

    }
}
