using System;

namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;
            Random random = new Random();
            int dieValue=random.Next(1,7);
            Console.WriteLine("Number Obtained is:"+ dieValue);

            //UC-3 Using Random class to generate the 3 available options
            //0-Noplay
            //1-Ladder
            //3-snake 

            int optionCheck = random.Next(0,3);

        

            if (optionCheck == 0) 
            {
                Console.WriteLine("Player Option is No play");
                Console.WriteLine("Player Current position is: "+playerPosition);
            }

            if (optionCheck == 1)
            {
                Console.WriteLine("Player Option is Ladder");
                playerPosition = playerPosition + dieValue;
                Console.WriteLine("Player Current position is: " + playerPosition);
            }

            if (optionCheck == 2)
            {
                Console.WriteLine("Player Option is Snake :-(");
                playerPosition = playerPosition - dieValue;
                Console.WriteLine("Player Current position is: " + playerPosition);
            }
        }
    }
}
