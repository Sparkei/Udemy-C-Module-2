using System;
using System.Collections.Generic;

namespace Assignment11
{
    class Program
    {
        static void Main(string[] args)
        {
            var playersList = new List<Tuple<int, string, int>>();
            AddPlayer(Tuple.Create(9, "Domnic Calvert Lewin", 10), ref playersList);
            AddPlayer(Tuple.Create(7, "Son Henug-Min", 9), ref playersList);
            AddPlayer(Tuple.Create(7, "Son Henug-Min", 9), ref playersList);

            foreach (var player in playersList)
            {
                Console.WriteLine(player.Item1);
                Console.WriteLine(player.Item2);
                Console.WriteLine(player.Item3);
                Console.WriteLine("---------");
            }
        }
        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list)
        {
            list.Add(player);
        }

        public static void AddPlayer(Tuple<int, string, int> player, ref List<Tuple<int, string, int>> list, int index)
        {
            list.Insert(index, player);
        }

        public static void RemovePlayer(int index, ref List<Tuple<int, string, int>> list)
        {
            list.RemoveAt(index);
        }
    }
}


