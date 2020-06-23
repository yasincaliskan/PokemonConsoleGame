using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Places
{
    public class Arena
    {
        public List<Trainer> Trainers { get; set; }
        public Rosette Rosette { get; set; }

        public void DoTournament(Trainer player, Trainer opponent)
        {
            //fight
        }
    }
}
