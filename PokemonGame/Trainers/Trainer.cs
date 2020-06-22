using PokemonGame.Pokemons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Trainers
{
    public class Trainer
    {
        public string Nickname { get; set; }
        public List<Pokemon> Pokemons { get; set; }
        public int Pokeballs { get; set; }
        public int Potions { get; set; }

        public Trainer()
        {
            this.Pokemons = new List<Pokemon>();
            this.Pokeballs = 3;
            this.Potions = 2;
        }
        public Trainer(string nickname)
        {
            this.Nickname = nickname;
            this.Pokemons = new List<Pokemon>();
            this.Pokeballs = 3;
            this.Potions = 2;
        }

        public void UsePotion(Trainer trainer)
        {
            int index = 1;
            int choice;
            Console.WriteLine("Use potion to: ");
            foreach (var item in trainer.Pokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
            }
            choice = Convert.ToInt32(Console.ReadLine());
            trainer.Pokemons[choice - 1].Health += 30;
            trainer.Potions--;
        }
        
        public void UsePokeball(Pokemon wildPokemon, Trainer trainer)
        {
            if(wildPokemon.Health < 20 || wildPokemon.Health > 0)
            {
                Console.WriteLine($"You catched {wildPokemon.Name}!");
                trainer.Pokemons.Add(wildPokemon);
                this.Pokeballs--;
            }
            else
            {
                Console.WriteLine($"You can not catch {wildPokemon.Name}");
            }
        }
    }
}
