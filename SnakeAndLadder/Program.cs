using System;

namespace SnakeAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Sanke and Ladder game");
            Player firstPlayer = new Player("First Player");
            Player secondPlayer = new Player("Second Player");
            SnakeAndLadder.Program.PlayGame(firstPlayer,secondPlayer);
        }
        static void PlayGame(Player first, Player second)
        {
            string win = "NO PLAYER";
            Player player = first;
            first.noOfTurns = 0;
            second.noOfTurns = 0;
            first.position = 0;
            second.position = 0;
            Console.WriteLine("Start Position : " + player.position);
            while ((win != first.playerName) && (win!=second.playerName))
            {
                bool playerChance = true;
                while ((player.position < 100) && (playerChance==true))
                {
                    Console.WriteLine("\n"+player.playerName);
                    player.noOfTurns++;
                    int diceNo = SnakeAndLadder.Program.RollDice();
                    Console.WriteLine("Dice rolled : " + diceNo);
                    Console.WriteLine("No of Turns : " + player.noOfTurns);
                    int option = SnakeAndLadder.Program.CheckOption();
                    switch (option)
                    {
                        case 0:
                            Console.WriteLine("No Play");
                            Console.WriteLine("New Position : " + player.position);
                            playerChance = false;
                            break;
                        case 1:
                            Console.WriteLine("Ladder");
                            player.position += diceNo;
                            player.noOfTurns -= 1;
                            if (player.position > 100)
                                player.position -= diceNo;
                            Console.WriteLine("New Position : " + player.position);
                            playerChance = true;
                            break;
                        case 2:
                            Console.WriteLine("Snake");
                            player.position -= diceNo;
                            if (player.position < 0)
                                player.position = 0;
                            Console.WriteLine("New Postion : " + player.position);
                            playerChance = false;
                            break;
                    }
                }
                if (player.position == 100)
                {
                    win = player.playerName;
                    Console.WriteLine("\n"+player.playerName + " Won");
                }
                if (player==first)
                {
                    player = second;
                }
                else
                {
                    player = first;
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
    public class Player
    {
        public string playerName;
        public int position;
        public int noOfTurns;
        public Player(string name)
        {
            playerName = name;
        }
    }
}
