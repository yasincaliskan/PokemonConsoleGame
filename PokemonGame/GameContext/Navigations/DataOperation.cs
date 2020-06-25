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
        static string savedFilePath = System.IO.Directory.GetCurrentDirectory();
        public static void SaveData(Trainer trainer)
        {
            string savedFilePath = System.IO.Directory.GetCurrentDirectory();
            string json = JsonConvert.SerializeObject(trainer);
            System.IO.File.WriteAllText(savedFilePath + "\\trainer.json", json);
        }
        public static Trainer LoadData()
        {
            string json = System.IO.File.ReadAllText(savedFilePath + "\\trainer.json");
            Console.WriteLine(json);
            Trainer trainer = JsonConvert.DeserializeObject<Trainer>(json);
            Console.WriteLine(trainer.ToString());
            return trainer;
        }
    }
}
