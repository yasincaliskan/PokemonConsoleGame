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
            Random rnd = new Random();
            Pokemon selectedPokemon = Menu.SelectPokemon(trainer);
            //if (selectedPokemon.baseProps.Speed > wildPokemon.baseProps.Speed)
            //{

            selectedPokemon.ShowProps();

                while (selectedPokemon.CurrentHealth > 0 || wildPokemon.CurrentHealth > 0)
                {
                    Console.WriteLine("1. Attack\n2. Go to Bag");
                    Console.Write("->");
                    choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Attack(selectedPokemon, wildPokemon);
                            break;
                        case 2:
                            UseItem.GoToBag(wildPokemon, trainer);
                            break;
                        default:
                            Console.WriteLine("Opss! You missed your attack chance.");
                            break;
                    }

                    double wildPokemonDamage = wildPokemon.CalculateDamage(wildPokemon);
                    selectedPokemon.CurrentHealth -= wildPokemonDamage;
                    Console.WriteLine($"{wildPokemon.name.english} damaged {wildPokemonDamage}! {selectedPokemon.name.english} {selectedPokemon.CurrentHealth} lives health.");

                    if (selectedPokemon.CurrentHealth <= 0)
                    {
                        selectedPokemon.Status = false;
                        Console.WriteLine($"{selectedPokemon.name.english} passed out!\nYou should go to PokeCenter!");
                    }
                    else if (wildPokemon.CurrentHealth <= 0)
                    {
                        wildPokemon.Status = false;
                        Console.WriteLine($"{wildPokemon.name.english} passed out! You can not catch it.");
                        selectedPokemon.EXP += rnd.Next(10, 20);
                    }
                }
            //}
        }

        public static void Battle(Trainer trainer, Player opponent)
        {
            Random rnd = new Random();
            Pokemon trainerPokemon = Menu.SelectPokemon(trainer);
            Pokemon opponentPokemon = Menu.SelectPokemon(opponent);
            while (trainerPokemon.CurrentHealth > 0 || opponentPokemon.CurrentHealth > 0)
            {
                Console.WriteLine("1. Attack\n2. Change Pokemon\n 0. Leave the match");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Attack(trainerPokemon, opponentPokemon);
                        break;
                    case 2:
                        trainerPokemon = Menu.SelectPokemon(trainer);
                        break;
                    case 0:
                        Menu.MainActions(trainer);
                        break;
                }
            }
            if (trainerPokemon.CurrentHealth <= 0)
            {
                trainerPokemon.Status = false;
                Console.WriteLine($"{trainerPokemon.name.english} passed out!\nYou should go to PokeCenter!");
            }
            {
                opponentPokemon.Status = false;
                Console.WriteLine($"{opponentPokemon.name.english} passed out! You can not catch it.");
                opponentPokemon.EXP += rnd.Next(10, 20);
            }
        }

        public static void Attack(Pokemon trainerPokemon, Pokemon opponentPokemon)
        {
            double trainerDamage = trainerPokemon.CalculateDamage(opponentPokemon);
            opponentPokemon.CurrentHealth -= trainerDamage;
            Console.WriteLine($"{trainerPokemon.name.english} damaged {trainerDamage}! {opponentPokemon.name.english} {opponentPokemon.CurrentHealth} lives health.");
        }

        public static void OpponentAttack(Pokemon trainerPokemon, Pokemon opponentPokemon)
        {
            double opponentDamage = opponentPokemon.CalculateDamage(opponentPokemon);
            trainerPokemon.CurrentHealth -= opponentDamage;
            Console.WriteLine($"{opponentPokemon.name.english} damaged {opponentDamage}! {trainerPokemon.name.english} {trainerPokemon.CurrentHealth} lives health.");


        }

        public static void HuntWildPokemon(Trainer trainer)
        {
            Random rnd = new Random();
            List<Pokemon> wildPokemons = Creation.StartingObjects();
            int randomNumber = rnd.Next(0, wildPokemons.Count);
            Pokemon wildPokemon = wildPokemons[randomNumber];

            Console.WriteLine($"Hey! It's a {wildPokemon.name.english}.");
            Battle(wildPokemon, trainer);
        }


    }
}
