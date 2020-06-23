using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Places
{
    public class Pokecenter
    {
        public void GoToPokecenter(Trainer trainer)
        {
            Console.WriteLine("Welcome to PokeCenter!");
            Console.WriteLine("1. Rehabilitation\n2. But Item");
            int choice = Convert.ToInt32(Console.ReadLine());
            if(choice == 1)
            {
                Rehabilitation(trainer);
            }
            else if(choice == 2)
            {
                BuyItem(trainer);
            }
        }
        public void Rehabilitation(Trainer trainer)
        {
            List<Pokemon> trainerPokemons = new List<Pokemon>();
            trainerPokemons = trainer.Pokemons;

            Console.WriteLine("Your pokemons are healed!");
            foreach (var item in trainerPokemons)
            {
                int index = 1;
                item.CurrentHealth = item.MaxHealth;
                Console.WriteLine($"{index}. {item.Name} - {item.CurrentHealth} HP");
                index++;
            }
        }

        public void BuyItem(Trainer trainer)
        {
            //
        }
    }
}
