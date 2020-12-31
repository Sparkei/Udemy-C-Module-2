using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfPlayers = new List<(int playerNo, string PlayerName, int PlayerGoals)>();

            listOfPlayers.Add((9, "Domnic Calvert Lewin", 10));
            listOfPlayers.Add((7, "Son Henug-Min", 9));
            listOfPlayers.Add((11, "Mohamed Salah", 8));
            listOfPlayers.Add((9, "Jamie Vardy", 8));

            foreach (var player in listOfPlayers)
            {
                Console.WriteLine($"{ player.playerNo} { player.PlayerName} has scored {player.PlayerGoals} goals so far");
                Console.WriteLine("--------------------------------------------");

            }
        }
    }
}
