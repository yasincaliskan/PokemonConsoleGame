using PokemonGame.Context.Creation;
using PokemonGame.GameContext.Navigations;
using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Places
{
    public static class Pokecenter
    {
        public static void GoToPokecenter(Trainer trainer)
        {
            Console.WriteLine("Welcome to PokeCenter!");
            Console.WriteLine("1. Rehabilitation\n2. Buy Item");
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
        public static void Rehabilitation(Trainer trainer)
        {
            List<Pokemon> trainerPokemons = new List<Pokemon>();
            trainerPokemons = trainer.Pokemons;
            int index = 1;
            Console.WriteLine("Your pokemons are healed!");
            foreach (var item in trainerPokemons)
            {
                item.HP = PokemonFactory.CreateSpecificPokemon(item.name.english).HP;
                Console.WriteLine($"{index}. {item.name.english} - {item.HP} HP");
                index++;
            }

            Menu.MainActions(trainer);
        }

        public static void BuyItem(Trainer trainer)
        {
            int choice;
            Console.WriteLine("1. Buy Pokeball\n2. Buy Potion\n0. Main Menu\n->");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    if (trainer.Pokeballs <= 6)
                    {
                        trainer.Pokeballs += 1;
                        Console.WriteLine($"You bought 1 Pokeball. You have {trainer.Pokeballs} Pokeball.");
                    }
                    break;
                case 2:
                    if(trainer.Potions <= 5)
                    {
                        trainer.Potions += 1;
                        Console.WriteLine($"You bought 1 Potion. You have {trainer.Potions} Potion.");
                    }
                    break;
                default:
                    Menu.MainActions(trainer);
                    break;
            }

            Menu.MainActions(trainer);

        }
    }
}
