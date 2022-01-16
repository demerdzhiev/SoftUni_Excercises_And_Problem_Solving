using System;
using System.Collections.Generic;
using System.Linq;

namespace T03.ThePianist
{
    class Piece
    {
        public string PieceComposer { get; set; }

        public string PieceKey { get; set; }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Piece> pieces = new Dictionary<string, Piece>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                // Fur Elise|Beethoven|A Minor
                string[] input = Console.ReadLine().Split("|");
                pieces.Add(input[0], new Piece()
                {
                    PieceComposer = input[1],
                    PieceKey = input[2],
                });
            }
            string command = Console.ReadLine();
            while (command != "Stop")
            {
                string[] splittedCommand = command.Split("|");
                if (splittedCommand[0] == "Add") // Add|{piece}|{composer}|{key}
                {
                    if (!pieces.ContainsKey(splittedCommand[1]))
                    {
                        pieces.Add(splittedCommand[1], new Piece()
                        {
                            PieceComposer = splittedCommand[2],
                            PieceKey = splittedCommand[3],
                        });
                        Console.WriteLine($"{splittedCommand[1]} by {splittedCommand[2]} in {splittedCommand[3]} added to the collection!");
                    }
                    else
                    {
                        Console.WriteLine($"{splittedCommand[1]} is already in the collection!");
                    }
                }
                else if (splittedCommand[0] == "Remove") // Remove|{piece}":
                {
                    if (!pieces.ContainsKey(splittedCommand[1]))
                    {
                        Console.WriteLine($"Invalid operation! {splittedCommand[1]} does not exist in the collection.");
                    }
                    else
                    {
                        pieces.Remove(splittedCommand[1]);
                        Console.WriteLine($"Successfully removed {splittedCommand[1]}!");
                    }
                }
                else if (splittedCommand[0] == "ChangeKey") // ChangeKey|{piece}|{new key}
                {
                    if (!pieces.ContainsKey(splittedCommand[1]))
                    {
                        Console.WriteLine($"Invalid operation! {splittedCommand[1]} does not exist in the collection.");
                    }
                    else
                    {

                        pieces[splittedCommand[1]].PieceKey = splittedCommand[2];
                        Console.WriteLine($"Changed the key of {splittedCommand[1]} to {splittedCommand[2]}!");
                    }
                }
                command = Console.ReadLine();
            }
            pieces = pieces.OrderBy(n => n.Key).ThenBy(c => c.Value.PieceComposer).ToDictionary(k => k.Key, v => v.Value);
            foreach (var piece in pieces)
            {
                Console.WriteLine($"{piece.Key} -> Composer: {piece.Value.PieceComposer}, Key: {piece.Value.PieceKey}");
            }
            
        }
    }
}
