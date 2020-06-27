using PokemonGame.Pokedex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{

    public class Pokemon
    {
        public int id { get; set; }
        public Language name { get; set; }
        public List<string> type { get; set; }
        public string HP { get; set; }
        public int Attack { get; set; }
        public int Defense { get; set; }
        public int SpAttack { get; set; }
        public int SpDefense { get; set; }
        public int Speed { get; set; }
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public bool Status { get; set; }
        public int Level { get; set; }
        public double EXP { get; set; }

        public Pokemon()
        {   
            this.EXP = 0;
            this.CurrentHealth = 50;
            this.MaxHealth = 50;
            this.Level = 1;
            this.Status = true;
        }

        public double CalculateDamage(Pokemon opponentPokemon) // interface method
        {
            Random rnd = new Random();
            int Power = 50;
            double modifier = TypeEffectivenes(opponentPokemon) * rnd.Next(85, 100) / 100;

            double Damage = (((((2 * Level) / 5) + 2) * Power * (this.Attack / this.Defense) / 50) + 2);// * modifier;
            return Damage;
        }

        public double TypeEffectivenes(Pokemon opponentPokemon)
        {
            double effectValue = 0.0;

            foreach (var current in this.type)
            {
                foreach (var opponent in opponentPokemon.type)
                {
                    //if (current.immunes.Contains(opponent.name))
                    //{
                    //    effectValue = 5;
                    //}
                    //else if (current.strengths.Contains(opponent.name))
                    //{
                    //    effectValue = 3;
                    //}
                    //else if (current.weaknesses.Contains(opponent.name))
                    //{
                    //    effectValue = -3;
                    //}
                    //else
                    //{
                    //    effectValue = 1;
                    //}
                   
                }
            }
            return effectValue;
        }

        public void ShowProps()
        {
            Console.WriteLine($"{this.name.english} - max hp {this.MaxHealth} - sp {this.Speed} - {this.Attack}");
        }

        public void Evolve()
        {
            this.Level += 1;
            this.MaxHealth += 30 + this.Level;
            this.Attack += this.Level * 2;
            this.Defense += this.Level * 2;
        }
    }
}

