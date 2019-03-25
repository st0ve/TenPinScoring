using System;
using System.Collections.Generic;
using System.Linq;
using TenPinScoring.Entities;

namespace TenPinScoring
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> rolls = new Queue<int>(args.Select(int.Parse));

            Game game = new Game();
            game.SetupGame(10);
            GameResult result = game.Play(rolls);

            Console.WriteLine($"Rolls input: {string.Join(" ", args)}");
            Console.WriteLine($"Frame outcomes: {string.Join(" ", result.Outcomes)}");
            Console.WriteLine($"Final score: {result.FinalScore}");
        }
    }
}
