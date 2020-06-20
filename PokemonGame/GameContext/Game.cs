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
    }
}
