using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Trainer : Player
    {
        public int Pokeballs { get; set; }
        public int Potions { get; set; }

        public Trainer()
        {
            this.Pokeballs = 3;
            this.Potions = 2;
        }
        public void UsePotion()
        {
            int index = 1;
            int choice;
            Console.WriteLine("Use potion to: ");
            foreach (var item in this.Pokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
            }
            choice = Convert.ToInt32(Console.ReadLine());
            if (this.Pokemons[choice - 1].CurrentHealth + 30 < this.Pokemons[choice - 1].MaxHealth)
            {
                this.Pokemons[choice - 1].CurrentHealth += 30;
            }
            else
            {
                this.Pokemons[choice - 1].CurrentHealth = this.Pokemons[choice - 1].MaxHealth;
            }
            this.Potions--;
        }

        public void UsePokeball(Pokemon wildPokemon)
        {
            if (wildPokemon.CurrentHealth < 20 || wildPokemon.CurrentHealth > 0)
            {
                Console.WriteLine($"You catched {wildPokemon.Name}!");
                this.Pokemons.Add(wildPokemon);
                this.Pokeballs--;
            }
            else
            {
                Console.WriteLine($"You can not catch {wildPokemon.Name}! ");
            }
        }

        public override string ToString()
        {
            string trainerInfo = $"Name: {this.Nickname}\n";
            foreach (var item in this.Pokemons)
            {
                trainerInfo += $"-{item.Name}";
            }
            return trainerInfo;
        }
    }
}
