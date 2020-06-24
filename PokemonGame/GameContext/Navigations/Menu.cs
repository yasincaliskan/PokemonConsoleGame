﻿using PokemonGame.GameContext.Actions;
using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext.Navigations
{
    public static class Menu
    {
        static int choice;
        public static void StartGame()
        {
            Console.WriteLine("Welcome to Pokémon world!");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                NewGame();
            }
            else if (choice == 2)
            {
                LoadGame();
            }
        }

        public static void NewGame()
        {
            Trainer trainer = new Trainer();
            int index = 1;
            Console.Write("Please enter your nickname: ");
            trainer.Nickname = Console.ReadLine();
            Console.WriteLine($"Hi {trainer.Nickname}!");
            Console.WriteLine("Please select your first pokemon from Professor Oak.");

            List<Pokemon> initialPokemons = Creation.StartingPokemons();
            foreach (var item in initialPokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
                index++;
            }

            Console.Write("Select a Pokemon: ");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine()) - 1;
            Pokemon initialPokemon = initialPokemons[choice];
            trainer.Pokemons.Add(initialPokemon);
            Console.WriteLine($"Okay! {trainer.Pokemons[0].Name} is your first Pokémon!");
            MainActions(trainer);
        }

        public static void LoadGame()
        {

        }

        public static void SaveAndQuit()
        {

        }

        public static void MainActions(Trainer trainer)
        {
            Console.WriteLine("1. Hunt Pokemon\n2. Go to PokeCenter\n3. Go to Arena\n0. Save and Quit");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fight.HuntWildPokemon(trainer);
                    break;
                case 2:
                    //pokecenter
                    break;
                case 3:
                    //arena
                    break;
                case 0:
                    SaveAndQuit();
                    break;

                default:
                    MainActions(trainer);
                    break;
            }
        }
        public static Pokemon SelectPokemon(Trainer trainer)
        {
            int index = 1;
            Console.WriteLine("Select a Pokemon:");
            foreach (var item in trainer.Pokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
            }
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());

            Pokemon selectedPokemon = trainer.Pokemons[index - 1];
            return selectedPokemon;
        }

        public static void Battle(Pokemon wildPokemon, Trainer trainer)
        {
            Console.WriteLine("1. Fight\n2. Go to Bag");
            Console.WriteLine("->");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fight.Battle(wildPokemon, trainer);
                    break;
                case 2:
                    UseItem.GoToBag(wildPokemon, trainer);
                    break;
                default:
                    Battle(wildPokemon, trainer);
                    break;
            }
        }
    }
}
