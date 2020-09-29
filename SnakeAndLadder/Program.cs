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
            Console.WriteLine("Your Start Position : "+ position);
            int noOfTurns = 0;
            while (position < 100)
            {
                noOfTurns++;
                Console.WriteLine("Turn : " + noOfTurns);
                int diceNo = SnakeAndLadder.Program.RollDice();
                Console.WriteLine("Dice rolled : " + diceNo);
                int option = SnakeAndLadder.Program.CheckOption();
                switch (option)
                {
                    case 0:
                        Console.WriteLine("No Play");
                        Console.WriteLine("New Position : " + position);
                        break;
                    case 1:
                        Console.WriteLine("Ladder");
                        position += diceNo;
                        Console.WriteLine("New Position : " + position);
                        break;
                    case 2:
                        Console.WriteLine("Snake");
                        position -= diceNo;
                        if (position < 0)
                            position = 0;
                        Console.WriteLine("New Postion : " + position);
                        break;
                }
            }
        }
        static int RollDice()
        {
            Random random = new Random();
            int dice = random.Next(1, 7);
            return dice;
        }
        static int CheckOption()
        {
            Random random = new Random();
            int option = random.Next(0, 3);
            return option;
        }
    }
}
