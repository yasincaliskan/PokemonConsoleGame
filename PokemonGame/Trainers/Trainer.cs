using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Trainer :Player
    {
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
                Console.WriteLine($"You can not catch {wildPokemon.Name}");
            }
        }

        public void ShowRosettes()
        {
            int index = 1;
            foreach (var item in this.Rosettes)
            {
                Console.WriteLine($"{index}. {item.Name} - [{item.Arena}]");
                index++;
            }
        }
    }
}
