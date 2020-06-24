using PokemonGame.GameContext.Navigations;
using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext.Actions
{
    public static class Fight
    {
        static int choice;

        public static void Battle(Pokemon wildPokemon, Trainer trainer)
        {
            Pokemon selectedPokemon = Menu.SelectPokemon(trainer);
            if (selectedPokemon.Speed > wildPokemon.Speed)
            {
                while (selectedPokemon.CurrentHealth > 0 || wildPokemon.CurrentHealth > 0)
                {
                    Console.WriteLine("1. Attack\n 2. Go to Bag");
                    Console.WriteLine("->");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            double trainerDamage = selectedPokemon.DoAttack();
                            wildPokemon.CurrentHealth -= trainerDamage;
                            Console.WriteLine($"{selectedPokemon.Name} damaged {trainerDamage}! {wildPokemon.Name} {wildPokemon.CurrentHealth} lives health.");
                            break;
                        case 2:
                            UseItem.GoToBag(wildPokemon, trainer);
                            break;
                        default:
                            Console.WriteLine("Opss! You missed your attack chance.");
                            break;
                    }

                    double wildPokemonDamage = wildPokemon.DoAttack();
                    selectedPokemon.CurrentHealth -= wildPokemonDamage;
                    Console.WriteLine($"{wildPokemon.Name} damaged {wildPokemonDamage}! {selectedPokemon.Name} {selectedPokemon.CurrentHealth} lives health.");

                    if (selectedPokemon.CurrentHealth <= 0)
                    {
                        selectedPokemon.Status = false;
                        Console.WriteLine($"{selectedPokemon.Name} passed out!\nYou should go to PokeCenter!");
                    }
                    else if (wildPokemon.CurrentHealth <= 0)
                    {
                        wildPokemon.Status = false;
                        Console.WriteLine($"{wildPokemon.Name} passed out! You can not catch it.");
                    }
                }
            }
        }

        public static void HuntWildPokemon(Trainer trainer)
        {
            Random rnd = new Random();
            List<Pokemon> wildPokemons = Creation.CreateWildPokemons();
            int randomNumber = rnd.Next(0, wildPokemons.Count);
            Pokemon wildPokemon = wildPokemons[randomNumber];

            Console.WriteLine($"Hey! It's a {wildPokemon.Name}.");
            Battle(wildPokemon, trainer);

        }
    }
}
