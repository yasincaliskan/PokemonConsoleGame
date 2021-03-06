﻿using PokemonGame.GameContext.Actions;
using PokemonGame.GameContext.Navigations;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Places
{
    public class Arena
    {
        public string Name { get; set; }
        public List<Player> Opponents { get; set; }
        public Rosette Rosette { get; set; }

        public Arena(string name)
        {
            this.Name = name;
            this.Opponents = new List<Player>();
        }

        int choice;
        public void GoToArena(Trainer trainer)
        {

            Console.WriteLine($"Welcome to {this.Name} Arena!");
            Console.Write("1. Join Tournament\n2. Info\n0. Main Menu\n->");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    JoinTournament(trainer, this.Opponents);
                    break;
                case 2:
                    GiveInfo(trainer);
                    break;
                case 0:
                    Menu.MainActions(trainer);
                    break;
            }
        }

        public void JoinTournament(Trainer trainer, List<Player> opponents)
        {
            int choice;
            Console.WriteLine($"Welcome to {this.Name}!\nYou may have a chance for the {this.Rosette.Name}.\nBut firstly you have to fight with:");
            foreach (var opponent in opponents)
            {
            Console.WriteLine($"- {opponent.Nickname}");
            }
            Console.WriteLine("\n1. Fight!\n2. Leave the arena");
            Console.Write("->");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Fight.Battle(trainer, opponents);
                    break;
                case 2:
                    Menu.MainActions(trainer);
                    break;
                default:
                    break;
            }
        }

        public void GiveInfo(Trainer trainer)
        {
            foreach (var player in this.Opponents)
            {
                Console.WriteLine($"{player.Nickname}");
                foreach (var pokemon in player.Pokemons)
                {
                    Console.WriteLine($"-> {pokemon.name.english} - {pokemon.Level}");
                }
            }

            Console.WriteLine($"Rosette: {this.Rosette.Name}\n");

            GoToArena(trainer);
        }

        
    }
}
