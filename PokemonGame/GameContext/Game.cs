using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext
{
    public class Game
    {
        int choice;

        Trainer trainer = new Trainer();
        Random rnd = new Random();

        public List<Pokemon> StartingPokemons()
        {
            List<Pokemon> InitialPokemons = new List<Pokemon>();
            Pokemon initialBulbasaur = new Pokemon("Bulbasaur");
            Pokemon initialSquirtle = new Pokemon("Squirtle");
            Pokemon initialCharmander = new Pokemon("Charmander");
            InitialPokemons.Add(initialBulbasaur);
            InitialPokemons.Add(initialSquirtle);
            InitialPokemons.Add(initialCharmander);

            return InitialPokemons;
        }

        public List<PokemonType> CreateTypes(
            string name,
            List<PokemonType> AdvantangeAttack,
            List<PokemonType> DisadvantangeAttack,
            List<PokemonType> AdvatageDefense,
            List<PokemonType> DisadvatangeDefense
            )
        {
            List<PokemonType> PokemonTypes = new List<PokemonType>();
            PokemonType pokemonType = new PokemonType(name, AdvantangeAttack, DisadvantangeAttack, AdvatageDefense, DisadvatangeDefense);
            PokemonTypes.Add(pokemonType);
            return PokemonTypes;
        }

        public List<Pokemon> CreateWildPokemons()
        {
            List<Pokemon> wildPokemons = new List<Pokemon>();
            Pokemon Pidgey = new Pokemon("Pidgey");
            Pokemon Rattata = new Pokemon("Rattata");

            wildPokemons.Add(Pidgey);
            wildPokemons.Add(Rattata);

            return wildPokemons;
        }


        public int StartGame()
        {
            Console.WriteLine("Welcome to Pokémon world!");
            Console.WriteLine("1. New Game");
            Console.WriteLine("2. Load Game");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());
            return choice;
        }

        public int NewGame()
        {
            int index = 1;
            Console.Write("Please enter your nickname: ");
            trainer.Nickname = Console.ReadLine();
            Console.WriteLine($"Hi {trainer.Nickname}!");
            Console.WriteLine("Please select your first pokemon from Professor Oak.");

            List<Pokemon> initialPokemons = StartingPokemons();
            foreach (var item in initialPokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
                index++;
            }

            Console.Write("Select a Pokémon: ");
            choice = Convert.ToInt32(Console.ReadLine())-1;
            Pokemon initialPokemon = initialPokemons[choice];
            trainer.Pokemons.Add(initialPokemon);
            Console.WriteLine($"Okay! {trainer.Pokemons[0].Name} is your first Pokémon!");


            return choice;
        }

        public void LoadGame()
        {

        }

        public void HuntWildPokemon()
        {
            List<Pokemon> wildPokemons = CreateWildPokemons();
            int randomNumber = rnd.Next(0, wildPokemons.Count);
            Pokemon wildPokemon = wildPokemons[randomNumber];

            Console.WriteLine($"Hey! It's a {wildPokemon.Name}.");
            Console.WriteLine("1. Fight\n2. Run");
            choice = Convert.ToInt32(Console.ReadLine());

            if(choice == 1)
            {
                Fight(wildPokemon);
            }
            else if(choice == 2)
            {
                Run();
            }
        }

        public void Fight(Pokemon wildPokemon)
        {
            Pokemon selectedPokemon = SelectPokemon();
            if(selectedPokemon.Speed > wildPokemon.Speed)
            {
                while(selectedPokemon.Health > 0 || wildPokemon.Health > 0)
                {
                    choice = FightMenu();
                    if(choice == 1)
                    {
                    double trainerDamage = selectedPokemon.DoAttack();
                    wildPokemon.Health -= trainerDamage;
                    Console.WriteLine($"{selectedPokemon.Name} damaged {trainerDamage}! {wildPokemon.Name} {wildPokemon.Health} lives health.");
                    }
                    else if(choice == 2)
                    {
                        GoToBag();
                    }

                    double wildPokemonDamage = wildPokemon.DoAttack();
                    selectedPokemon.Health -= wildPokemonDamage;
                    Console.WriteLine($"{wildPokemon.Name} damaged {wildPokemonDamage}! {selectedPokemon.Name} {selectedPokemon.Health} lives health.");


                }
            }
        }

        public int FightMenu()
        {
            Console.WriteLine("Choose:\n 1. Attack\n 2. Use item");
            choice = Convert.ToInt32(Console.ReadLine());

            return choice;
        }

        public void GoToBag()
        {
            int index = 1;
            Console.WriteLine("Select item:");
            foreach (var item in trainer.Items)
            {
                Console.WriteLine($"{index}. {item.}");
            }
        }

        public void Run()
        {

        }

        public Pokemon SelectPokemon()
        {
            int index = 1;
            Console.WriteLine("Select a Pokémon:");
            foreach (var item in trainer.Pokemons)
            {
                Console.WriteLine($"{index}. {item.Name}");
            }
            choice = Convert.ToInt32(Console.ReadLine());

            Pokemon selectedPokemon = trainer.Pokemons[index - 1];
            return selectedPokemon;
        }


    }
}
