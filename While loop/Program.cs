using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int j = 0;
            while (j <= 10)
            {
                Console.WriteLine("Value of j is " + j);
                j++;
            }
            Console.ReadKey();

            Console.WriteLine("Extension 1:-----------------------------------------------------------");
            Extension1();

            Console.WriteLine("Extension 2:-----------------------------------------------------------");
            Extension2();

            Console.WriteLine("Extension 3:-----------------------------------------------------------");
            Extension3();
        }

        public static void Extension1()
        {
            Random throwsOfDice = new();
            int thirtyDiceRolls = 0;
            int score = 0;

            while (thirtyDiceRolls <= 30)
            {
                thirtyDiceRolls = throwsOfDice.Next(1, 30);
                score += 1;
                Console.WriteLine("The total score is: " + score);
            }
        }

        public static void Extension2()
        {
            int timer = 0;

            Console.WriteLine("Enter a number");
            int userInput = int.Parse(Console.ReadLine());
            while (timer <= userInput)
            {
                timer++;
                Console.WriteLine("It takes " + timer + " amount of time to roll a dice");
            }
        }

        public static void Extension3()
        {
            int totalRolls = 6000;

            Console.WriteLine("Type in the expected amount of rolls to get up to 6000");
            int expectedRolls = int.Parse(Console.ReadLine());
            int actualRolls = totalRolls;

            while (expectedRolls < actualRolls)
            {
                Console.WriteLine("It took " + actualRolls + " rolls compared to what was expected: " + expectedRolls);
            }
        }
    }
}