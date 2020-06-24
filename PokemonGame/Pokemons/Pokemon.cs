using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Pokemons
{
    public delegate void EvolveEventHandler(object sender, Pokemon args);
    public class Pokemon
    {
        public event EvolveEventHandler Evolve;
        public string Name { get; set; }
        public double Attack { get; set; }
        public double Defense { get; set; }
        public double Speed { get; set; }
        public double HitPoint { get; set; }
        public double EXP
        {
            get { return EXP; }
            set
            {
                EXP = value;
                if (value >= Level * 10)
                {
                    //Evolving(this, );
                }
            }
        }
        public double MaxHealth { get; set; }
        public double CurrentHealth { get; set; }
        public bool Status { get; set; }
        public PokemonType Type { get; set; }
        public int Level
        {
            get; set;
        }


        public Pokemon(string name)
        {
            this.Name = name;
        }

        public Pokemon(string name, double attack, double defense, double speed, double hitpoint, PokemonType type, double health = 50, int level = 1)
        {
            this.Name = name;
            this.Attack = attack;
            this.Defense = defense;
            this.Speed = speed;
            this.HitPoint = hitpoint;
            this.EXP = 0;
            this.CurrentHealth = health;
            this.MaxHealth = health;
            this.Level = level;
            this.Type = type;
            this.Status = true;
        }

        public double CalculateDamage() // interface method
        {
            Random rnd = new Random();
            int Power = 50;
            double modifier;
            //if (this.Type.AdvantageAttack != null)
            //{
            //    Modifier = 5 * rnd.Next(1); //TODO: Effectivenes * Random (0.85-1)
            //}
            //else if (this.Type.DisadvantageAttack != null)
            //{
            //    Modifier = -5 * rnd.Next(1);
            //}
            //else
            //{
            //    Modifier = rnd.Next(1);
            //}
            modifier = rnd.Next(1);
            double Damage = (((((2 * Level) / 5) + 2) * Power * (Attack / Defense) / 50) + 2) * modifier;
            return Damage;
        }

        public void Evolving(Pokemon pokemon)
        {
            this.Level += 1;
            this.MaxHealth += 30 + this.Level;
            this.Attack += this.Level * 2;
            this.Defense += this.Level * 1.5;

        }
    }
}

