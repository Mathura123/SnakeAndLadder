using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sanke and Ladder game");
            SnakeAndLadder.Program.PlayGame();        
        }
        static void PlayGame()
        {
            int position = 0;
            Console.WriteLine("Your Position : "+ position);
            int diceNo = SnakeAndLadder.Program.RollDice();
            Console.WriteLine("Dice rolled : "+ diceNo);
        }
        static int RollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
    }
}
