using PokemonGame.Places;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Rosette
    {
        public string Name { get; set; }
        public Arena Arena { get; set; }

        public Rosette(string name)
        {
            this.Name = name;
        }
    }
}
