using PokemonGame.Context.Creation;
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


            while (selectedPokemon.HP > 0 || wildPokemon.HP > 0)
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
                        Console.WriteLine("Opss! You missed your attack chance.\n");
                        break;
                }

                double wildPokemonDamage = wildPokemon.CalculateDamage(wildPokemon);
                selectedPokemon.HP -= Convert.ToInt32(wildPokemonDamage);
                Console.WriteLine($"{wildPokemon.name.english} damaged {wildPokemonDamage}! {selectedPokemon.name.english} {selectedPokemon.HP} lives health.\n");

                if (selectedPokemon.HP <= 0)
                {
                    selectedPokemon.Status = false;
                    Console.WriteLine($"{selectedPokemon.name.english} passed out!\nYou should go to PokeCenter!\n");

                    Menu.MainActions(trainer);
                    break;
                }
                else if (wildPokemon.HP <= 0)
                {
                    wildPokemon.Status = false;
                    Console.WriteLine($"{wildPokemon.name.english} passed out! You win!\n");
                    selectedPokemon.EXP += rnd.Next(10, 20);


                    Menu.MainActions(trainer);
                    break;
                }
            }

            Menu.MainActions(trainer);

        }

        public static void Battle(Trainer trainer, List<Player> opponents)
        {
            Random rnd = new Random();
            Pokemon trainerPokemon = Menu.SelectPokemon(trainer);

            foreach (var opponent in opponents)
            {
                foreach (var opponentPokemon in opponent.Pokemons)
                {
                    while (trainerPokemon.HP > 0 && opponentPokemon.HP > 0)
                    {
                        Console.WriteLine("1. Attack\n2. Change Pokemon\n 0. Leave the match");
                        Console.Write("->");
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
                    if (trainerPokemon.HP <= 0)
                    {
                        trainerPokemon.Status = false;
                        Console.WriteLine($"{trainerPokemon.name.english} passed out!\nYou should go to PokeCenter!\n");
                        Console.WriteLine("1. Change Pokemon\n2. Leave the match");
                        Console.Write("->");
                        choice = Convert.ToInt32(Console.ReadLine());
                        switch (choice)
                        {
                            case 1:
                                trainerPokemon = Menu.SelectPokemon(trainer);
                                break;
                            case 2:
                                Menu.MainActions(trainer);
                                break;
                        }
                    }

                    opponentPokemon.Status = false;
                    Console.WriteLine($"{opponentPokemon.name.english} passed out!\n");
                    trainerPokemon.EXP += rnd.Next(10, 20);


                }
            }
            

        }

        public static void Attack(Pokemon trainerPokemon, Pokemon opponentPokemon)
        {
            double trainerDamage = trainerPokemon.CalculateDamage(opponentPokemon);
            opponentPokemon.HP -= Convert.ToInt32(trainerDamage);
            Console.WriteLine($"{trainerPokemon.name.english} damaged {trainerDamage}! {trainerPokemon.name.english} {trainerPokemon.HP} lives health.");
        }

        public static void OpponentAttack(Pokemon trainerPokemon, Pokemon opponentPokemon)
        {
            double opponentDamage = opponentPokemon.CalculateDamage(opponentPokemon);
            trainerPokemon.HP -= Convert.ToInt32(opponentDamage);
            Console.WriteLine($"{opponentPokemon.name.english} damaged {opponentDamage}! {opponentPokemon.name.english} {opponentPokemon.HP} lives health.\n");


        }

        public static void HuntWildPokemon(Trainer trainer)
        {
            Pokemon wildPokemon = PokemonFactory.CreateWildPokemon();
            Console.WriteLine($"Hey! It's a {wildPokemon.name.english}.\n");
            Battle(wildPokemon, trainer);
        }


    }
}
