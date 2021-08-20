using System;
using System.Collections.Generic;
using System.Linq;

namespace The_Pianist
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, string> pieceComposer = new Dictionary<string, string>();
            Dictionary<string, string> pieceKey = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                //  {piece}|{composer}|{key}
                string[] input = Console.ReadLine().Split("|");
                string piece = input[0];
                string composer = input[1];
                string key = input[2];

                pieceComposer.Add(piece, composer);
                pieceKey.Add(piece, key);
            }

            while (true)
            {
                string[] comand = Console.ReadLine().Split("|");

                if (comand[0] == "Stop")
                {
                    break;
                }

                if (comand[0] == "Add")
                {
                    // •	Add|{piece}|{composer}|{key} 

                    string piece = comand[1];
                    string composer = comand[2];
                    string key = comand[3];

                    if (pieceComposer.ContainsKey(piece))
                    {
                        Console.WriteLine($"{piece} is already in the collection!");
                    }
                    else
                    {
                        pieceComposer.Add(piece, composer);
                        pieceKey.Add(piece, key);

                        Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
                    }
                }
                else if (comand[0] == "Remove")
                {
                    // •	Remove|{piece} 

                    string piece = comand[1];

                    if (pieceComposer.ContainsKey(piece))
                    {
                        pieceComposer.Remove(piece);
                        pieceKey.Remove(piece);

                        Console.WriteLine($"Successfully removed {piece}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
                else if (comand[0] == "ChangeKey")
                {
                    // •	ChangeKey|{piece}|{new key} 

                    string piece = comand[1];                    
                    string newKey = comand[2];

                    if (pieceComposer.ContainsKey(piece))
                    {
                        pieceKey[piece] = newKey;

                        Console.WriteLine($"Changed the key of {piece} to {newKey}!");
                    }
                    else
                    {
                        Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
                    }
                }
            }
            // "{Piece} -> Composer: {composer}, Key: {key}"

            pieceComposer = pieceComposer
                .OrderBy(p => p.Key)
                .ThenBy(p => p.Value)
                .ToDictionary(p => p.Key, p => p.Value);

            foreach (var kvp in pieceComposer)
            {
                Console.WriteLine($"{kvp.Key} -> Composer: {kvp.Value}, Key: {pieceKey[kvp.Key]}");
            }
        }
    }
}
