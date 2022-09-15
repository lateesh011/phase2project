using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1project
{
    public class Player
    {
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public int PlayerAge { get; set; }


    }

    interface ITeam
    {
        void Add(Player player);
        void Remove(int playerId);
        Player GetPlayerById(int playerId);
        Player GetPlayerByName(string playerName);
        List<Player> GetAllPlayers();
    }

    public class OneDayTeam : Player, ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();



        public OneDayTeam()
        {
            oneDayTeam.Capacity = 11;
        }
        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public List<Player> GetAllPlayers()
        {
            return oneDayTeam;
        }

        public Player GetPlayerById(int playerId)
        {
            Player player = null;

            foreach (var item in oneDayTeam)
            {
                if (item.PlayerId == playerId)
                {
                    player = item;
                    break;
                }

            }
            return player;

        }

        public Player GetPlayerByName(string playerName)
        {
            Player player = null;

            foreach (var item in oneDayTeam)
            {
                if (item.PlayerName == playerName)
                {
                    player = item;
                    break;
                }

            }
            return player;
        }

        public void Remove(int playerId)
        {
            Player player = null;

            foreach (var item in oneDayTeam)
            {
                if (item.PlayerId == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", item.PlayerId);
                    player = item;
                }
            }
            oneDayTeam.Remove(player);


        }

    }
}
