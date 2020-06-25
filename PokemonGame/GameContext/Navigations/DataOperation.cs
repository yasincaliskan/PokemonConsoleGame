using Newtonsoft.Json;
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
        public static void SaveData(Trainer trainer)
        {
            string savedFilePath = System.IO.Directory.GetCurrentDirectory();
            Console.WriteLine(savedFilePath);
            string json = JsonConvert.SerializeObject(trainer);
            // System.IO.File.WriteAllText(savedFilePath + "\\deneme.json", json);
        }
        public static void LoadData()
        {

        }
    }
}
