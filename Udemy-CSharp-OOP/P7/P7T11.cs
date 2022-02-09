// Add and remove methods for list of tuples

using System;
using System.Collections.Generic;
using System.Text;

namespace P7T11
{
    class Solution
    {
        public static void Main(string[] args)
        {
            PlayersList list = new PlayersList();
            var playerOne = (7, "Виктор Онопко", 40);
            var playerTwo = (16, "Вячеслав Малафеев", -432);
            var playerThree = (7, "Виктор Онопко", 40);
            list.Add(playerOne);
            list.Show();
            list.Add(playerTwo, 1);
            list.Show();
            list.Remove(0);
            list.Show();
        }
    }

    class PlayersList
    {
        List<(int PlayerNo, string PlayerName, int PlayerGoals)> players;

        public List<(int PlayerNo, string PlayerName, int PlayerGoals)> Players
        {
            get => players;
            set => players = value;
        }

        public PlayersList()
        {
            players = new List<(int PlayerNo, string PlayerName, int PlayerGoals)>();
        }

        public void Add((int PlayerNo, string PlayerName, int PlayerGoals) value)
        {
            players.Add(value);
        }

        public void Add((int PlayerNo, string PlayerName, int PlayerGoals) value, int index)
        {
            players.Insert(index, value);
        }

        public void Remove(int index)
        {
            players.RemoveAt(index);
        }

        public void Show()
        {
            Console.WriteLine("Players:");
            int playersNr = players.Count;
            int i = 0;
            foreach (var player in players)
            {
                Console.WriteLine($"{i}: {player}");
                i++;
            }
        }
    }
}
