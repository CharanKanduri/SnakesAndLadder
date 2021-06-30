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
        }
    }
}
