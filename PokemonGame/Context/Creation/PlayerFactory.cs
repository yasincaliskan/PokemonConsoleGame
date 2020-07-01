using PokemonGame.Places;
using PokemonGame.Trainers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonGame.Context.Creation
{
    public class PlayerFactory
    {
        public static Player CreateOpponent(string name)
        {
            Player player = new Opponent(name);
            return player;
        }

        public static List<Player> CreateOpponents(List<string> names)
        {
            List<Player> opponentList = new List<Player>();
            foreach (var name in names)
            {
                opponentList.Add(CreateOpponent(name));
            }
            return opponentList;
        }

        public static Rosette CreateRosette(string name)
        {
            return new Rosette(name);
        }

        public static Arena CreateArena(string arenaName, List<string> playerNames, string rosetteName)
        {
            Arena arena = new Arena(arenaName);
            List<Player> opponentPlayer = CreateOpponents(playerNames);

            foreach (var player in opponentPlayer)
            {
                arena.Opponents.Add(player);
            }

            arena.Rosette = CreateRosette(rosetteName);
            return arena;
        }

    }
}

