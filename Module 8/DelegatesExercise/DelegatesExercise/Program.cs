using System;
using System.Collections.Generic;

namespace DelegatesExercise
{
    public delegate void DisplayPlayer(Dictionary<int, string> players);
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> listOfPlayers = new Dictionary<int, string>();
            listOfPlayers.Add(1, "Alison");
            listOfPlayers.Add(66, "Trent Alexander Arnold");
            listOfPlayers.Add(9, "Roberto Firmino");
            listOfPlayers.Add(10, "Sadio Mane");
            listOfPlayers.Add(11, "Mohammed Salah");
            DisplayPlayer player = new DisplayPlayer(DisplayPlayerInfo);
            player(listOfPlayers);
        }

        private static void DisplayPlayerInfo(Dictionary<int, string> players)
        {
            foreach (var player in players)
            {
                Console.WriteLine($"Player Number: {player.Key}, player name: {player.Value}");
            }
        }
    }
}
