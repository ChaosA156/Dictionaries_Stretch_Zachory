using System;
using System.Collections.Generic;
using System.Collections;

namespace Dictionaries_Stretch_Zachory
{
    class Program
    {
        // A list of my favorite games. May Change in the future, except for the older Halo games. Those will always be my favorites. Reach and 3 change on and off.
        static void Main(string[] args)
        {
            Dictionary<int, string> topGames = new Dictionary<int, string>();
            topGames.Add(1, "Halo: Reach");
            topGames.Add(2, "Halo 3");
            topGames.Add(3, "Halo 2");
            topGames.Add(4, "Halo: Combat Evolved");
            topGames.Add(5, "SoulCalibur VI");
            topGames.Add(6, "SoulCalibur V");
            topGames.Add(7, "Darksiders II");
            topGames.Add(8, "Bendy and the Ink Machine");
            topGames.Add(9, "Elden Ring");
            topGames.Add(10, "Little Nightmares II");

            // Writes a line stating my favorite video game.
            foreach (KeyValuePair<int, string> kvp in topGames)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            if (topGames.ContainsKey(1))
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}.");
            }

            // Prints Rocket League to the screen or gives a message depending on certain conditions.
            string result = "";

            topGames.TryGetValue(11, out result);

            if (result != "")
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position");
            }

            if (topGames.ContainsKey(5)) ;
            {
                topGames[5] = "Rocket League";
            }

            // A list of States and their Capitals.
            Console.WriteLine(topGames[5]);

            Hashtable hashTable = new Hashtable(topGames);

            string favGame = (string)hashTable[1];

            Console.WriteLine($"Favorite Game: {favGame}");

            Hashtable capitals = new Hashtable() {
                { "Oklahoma", "Oklahoma City" },
                { "New York", "Albany" },
                { "Texas", "Austin"},
                { "Ohio", "Columbus" }
            };

            foreach (DictionaryEntry kvp in capitals)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            capitals.Clear();

        }
    }
}
