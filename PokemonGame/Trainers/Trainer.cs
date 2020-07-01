using PokemonGame.Context.Creation;
using PokemonGame.GameContext.Navigations;
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
            if (this.Potions > 0)
            {

                int index = 1;
                int choice;
                Console.WriteLine("Use potion to: ");
                foreach (var item in this.Pokemons)
                {
                    Console.WriteLine($"{index}. {item.name.english}");
                }
                choice = Convert.ToInt32(Console.ReadLine());
                if (this.Pokemons[choice - 1].HP + 25 < PokemonFactory.CreateSpecificPokemon(this.Pokemons[choice -1].name.english).HP)
            {
                this.Pokemons[choice - 1].HP += 25;
            }
            else
            {
                this.Pokemons[choice - 1].HP = PokemonFactory.CreateSpecificPokemon(this.Pokemons[choice - 1].name.english).HP;
            }
            this.Potions--;
            }
            else
            {
                Console.WriteLine("You have not any potion!");
            }
        }

        public void UsePokeball(Pokemon wildPokemon)
        {
            if (wildPokemon.HP < 20 || wildPokemon.HP > 0)
            {
                Console.WriteLine($"You catched {wildPokemon.name.english}!");
                this.Pokemons.Add(wildPokemon);
                this.Pokeballs--;
                Menu.MainActions(this);
            }
            else
            {
                Console.WriteLine($"You can not catch {wildPokemon.name.english}! ");
            }
        }

        public override string ToString()
        {
            string trainerInfo = $"Name: {this.Nickname}\n";
            foreach (var item in this.Pokemons)
            {
                trainerInfo += $"-{item.name.english}";
            }
            return trainerInfo;
        }
    }
}
