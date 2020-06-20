using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public class Pokemon
    {
        public string Name { get; set; }
        public double Attack { get; set; }
        public double Defense { get; set; }
        public double Speed { get; set; }
        public double HitPoint { get; set; }
        public double EXP { get; set; }
        public int Level { get; set; }
        public Types Type { get; set; }

        public double DoAttack() //Maybe be virtual
        {
            Random rnd = new Random();
            int Power = 50;
            if (Types.AdvantageAttack)
            {

            }
            double Modifier =  * rnd.Next(1); //TODO Effectivenes * Random (0.85-1)

            double Damage = (((((2 * Level) / 5) + 2) * Power * (Attack / Defense) / 50) + 2) * Modifier;
            return Damage;
        }
    }
}
