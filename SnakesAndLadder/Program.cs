using System;


namespace SnakesAndLadder
{
    class Program
    {
        static void Main(string[] args)
        {

            //UC-1 Player starting position is to be 0


            int playerPosition = 0;

            //UC-2 using random class to pick a number from 1 -6
            Random random = new Random();
            int dieValue=random.Next(1,7);
            Console.WriteLine("Number Obtained is:"+ dieValue);

            int count = 0;

            //UC-3 Using Random class to generate the 3 available options
            //0-Noplay
            //1-Ladder
            //3-snake 

            int optionCheck = random.Next(0,3);

            while (playerPosition <= 100)
            {
                Random random = new Random();
                int dieValue = random.Next(1, 7);
                Console.WriteLine("Number Obtained is:" + dieValue);


                int optionCheck = random.Next(0, 3);

                if (optionCheck == 0)
                {
                    Console.WriteLine("Player Option is No play");
                    Console.WriteLine("Player Current position is: " + playerPosition);
                    if (playerPosition < 0) playerPosition = 0;
                }



               

                if (optionCheck == 1)
                    {
                        Console.WriteLine("Player Option is Ladder");
                        playerPosition = playerPosition + dieValue;
                        Console.WriteLine("Player Current position is: " + playerPosition);
                    }

                if (optionCheck == 2)

                if (playerPosition + dieValue < 100)
                {

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
                        if (playerPosition < 0) playerPosition = 0;
                        Console.WriteLine("Player Current position is: " + playerPosition);

                    }

                
               

                }
                else if (playerPosition + dieValue == 100 && optionCheck == 1)
                {
                    playerPosition = playerPosition + dieValue;
                    Console.WriteLine("Player Current position is: " + playerPosition);
                    Console.WriteLine("Total number of times dice rolled :"+ count);
                    break;


                }
                count++;
            }


        }
    }

