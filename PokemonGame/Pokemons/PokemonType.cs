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

        public PokemonType(string name)
        {
            this.Name = name;
        }

        public PokemonType(
            string name,
            List<PokemonType> advantageAttack,
            List<PokemonType> disadvantageAttack,
            List<PokemonType> advantageDefense,
            List<PokemonType> disadvantageDefense)
        {
            this.Name = name;
            this.AdvantageAttack = advantageAttack;
            this.DisadvantageAttack = disadvantageAttack;
            this.AdvantageDefense = advantageDefense;
            this.DisadvantageDefense = disadvantageDefense;
        }

    }
}
