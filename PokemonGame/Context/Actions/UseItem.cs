using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext.Actions
{
    public static class UseItem
    {
        static int choice;
        public static void GoToBag(Pokemon wildPokemon, Trainer trainer)
        {
            Console.WriteLine("Select item:");
            Console.WriteLine($"1. Pokeball - {trainer.Pokeballs}\n2. Potion - {trainer.Potions}");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    trainer.UsePokeball(wildPokemon);
                    break;
                case 2:
                    trainer.UsePotion();
                    break;
                default:
                    break;
            }
        }
    }
}
