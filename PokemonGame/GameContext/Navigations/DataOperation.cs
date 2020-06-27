using Newtonsoft.Json;
using PokemonGame.Pokedex;
using PokemonGame.Pokemons;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.GameContext.Navigations
{
    public static class DataOperation
    {
        static string savedFilePath = System.IO.Directory.GetCurrentDirectory();
        public static void SaveGame(Trainer trainer)
        {
            string json = JsonConvert.SerializeObject(trainer);
            System.IO.File.WriteAllText(savedFilePath + "\\savedFiles\\trainer.json", json);
        }

        public static Trainer LoadGame()
        {
            string json = System.IO.File.ReadAllText(savedFilePath + "\\savedFiles\\trainer.json");
            Trainer trainer = JsonConvert.DeserializeObject<Trainer>(json);

            Console.WriteLine($"Welcome again {trainer.Nickname}!");
            Console.WriteLine(trainer.ToString());

            return trainer;
        }

        public static List<Pokemon> LoadPokemons()
        {
            string json = System.IO.File.ReadAllText(savedFilePath + "\\savedFiles\\pokedex.json");


            List<Pokemon> allPokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            return allPokemons;
        }

        public static List<PokemonType> LoadPokemonType()
        {

            string json = System.IO.File.ReadAllText(savedFilePath + "\\savedFiles\\types.json");
            List<PokemonType> allPokemons = JsonConvert.DeserializeObject<List<PokemonType>>(json);

            return allPokemons;
        }

        public static List<Pokemon> LoadInitialPokemons()
        {
            string json = System.IO.File.ReadAllText(savedFilePath + "\\savedFiles\\initialPokemons.json");
            List<Pokemon> initialPokemons = JsonConvert.DeserializeObject<List<Pokemon>>(json);

            return initialPokemons;
        }
    }
}
