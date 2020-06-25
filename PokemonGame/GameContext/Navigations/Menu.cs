using PokemonGame.GameContext.Actions;
using PokemonGame.Places;
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
                Trainer trainer = LoadGame();
                MainActions(trainer);
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

            Console.WriteLine("Select a Pokemon: ");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine()) ;
            Pokemon initialPokemon = initialPokemons[choice - 1];
            trainer.Pokemons.Add(initialPokemon);
            Console.WriteLine($"Okay! {trainer.Pokemons[0].Name} is your first Pokémon!");
            MainActions(trainer);
        }

        public static Trainer LoadGame()
        {
            //which trainer
            return DataOperation.LoadData();
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
                    Places.Pokecenter.GoToPokecenter(trainer);
                    break;
                case 3:
                    SelectArena(trainer);
                    break;
                case 0:
                    DataOperation.SaveData(trainer);
                    break;

                default:
                    MainActions(trainer);
                    break;
            }
        }
        public static Pokemon SelectPokemon(Player trainer)
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

        public static void SelectArena(Trainer trainer)
        {
            int index = 1;
            List<Arena> arenaList = Creation.CreateArenas();
            Console.WriteLine("Select a Arena: ");
            foreach (var item in arenaList)
            {
                Console.WriteLine($"{index}. {item.Name}");
                index++;
            }
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());
            Arena selectedArena = arenaList[choice - 1];
            selectedArena.GoToArena(trainer);
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
