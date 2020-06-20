using Pokemon.MainPokemon;
using Pokemon.MainTrainer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Pokemon World!");

            AnyPokemon pika = new AnyPokemon();
            pika.Name = "Pikachu";
            pika.EXP = 0;

            AnyPokemon charmander = new AnyPokemon();
            charmander.Name = "Charmander";

            List<AnyPokemon> InitialPokemons = new List<AnyPokemon>();
            InitialPokemons.Add(pika);
            InitialPokemons.Add(charmander);


            while (true) 
            {
                Console.WriteLine("Create an account");
                Trainer trainer = new Trainer();
                Console.Write("Nickname: ");
                trainer.Nickname = Console.ReadLine();

                Console.WriteLine($"Hey! {trainer.Nickname}..");
                Console.WriteLine("Select a Pokemon:");
                int index = 1;
                foreach (var item in InitialPokemons)
                {
                    Console.WriteLine($"{index}.{item.Name}");
                    index++;
                }

                int choise = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(InitialPokemons[choise-1].Name);
                var initialPokemon = InitialPokemons[choise - 1];
                //trainer.Pokemons.Add(initialPokemon); //Object reference error!

                Console.WriteLine($"Your choise: {trainer.Pokemons[0]}" );


                Console.ReadLine();
            }
        }
    }
}
