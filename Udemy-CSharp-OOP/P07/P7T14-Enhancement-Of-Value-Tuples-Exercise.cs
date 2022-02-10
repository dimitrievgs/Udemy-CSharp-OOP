// Enhancement of value tuples exercise

using System;
using System.Collections.Generic;
using System.Text;

namespace P7T14
{
    class Solution
    {
        public static void Main(string[] args)
        {
            var players = new List<(string PlayerName, List<FootballClub> Clubs, Country Country, int PlayerNo, int PlayerGoals)>();
            players.Add(("Александр Анюков", new List<FootballClub> { FootballClub.Zenit }, Country.Russia, 2, 13));
            players.Add(("Игорь Акинфеев", new List<FootballClub> { FootballClub.CSKA }, Country.Russia, 35, -404));
            players.Add(("Hugo Ayala", new List<FootballClub> { FootballClub.TigresUANL }, Country.Mexico, 2, 6));
            Console.WriteLine("Players:");
            foreach (var player in players)
            {
                Console.WriteLine($"{player.PlayerName} from {player.Country}, club: {string.Concat(player.Clubs)}, number: {player.PlayerNo}, goals: {player.PlayerGoals}.");
            }
        }
    }

    enum Country
    {
        China,
        India,
        UnitedStates,
        Indonesia,
        Pakistan,
        Brazil,
        Nigeria,
        Bangladesh,
        Russia,
        Mexico
    }

    enum FootballClub
    {
        Zenit,
        Spartak,
        CSKA,
        ATKMohunBagan,
        TigresUANL
    }
}
