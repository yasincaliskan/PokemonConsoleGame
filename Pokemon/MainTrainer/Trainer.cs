using Pokemon.MainPokemon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.MainTrainer
{
    public class Trainer
    {
        public string Nickname { get; set; }
        public List<AnyPokemon> Pokemons { get; set; }
        public int Pokeball { get; set; }
        public int Potion { get; set; }

        public Trainer()
        {
            Pokeball = 2;
            Potion = 1;
        }
    }
}
