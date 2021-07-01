using System;

namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerPosition = 0;

            //UC-2 using random class to pick a number from 1 -6
            Random random = new Random();
            int dieValue=random.Next(1,7);
            Console.WriteLine("Number Obtained is:"+ dieValue);
        }
    }
}
