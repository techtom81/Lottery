using System;
using System.Collections.Generic;

namespace Lottery
{
    class LottoGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick 6 unique numbers from 1-59");
            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();
            Console.WriteLine("Press any key to start");
            Console.ReadLine();

            Console.WriteLine("Please enter first number");
            int firstNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter second number");
            int secondNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter third number");
            int thirdNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter fourth number");
            int fourthNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter fifth number");
            int fifthNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter sixth number");
            int sixthNum = Convert.ToInt32(Console.ReadLine());

            int[] numbersArr = { firstNum, secondNum, thirdNum, fourthNum, fifthNum, sixthNum };
            string numbersStr = string.Join(",", numbersArr);
            Console.WriteLine("Thank you, your lottery numbers are {0}", numbersStr);
            Console.WriteLine("Press any key to start the draw, Good luck!");
            Console.ReadLine();
            int[] drawnNumbers = Draw();
            List<string> drawnStr = new List<string>();
            foreach (int number in drawnNumbers)
            {
                drawnStr.Add(number.ToString());
            }
            Console.WriteLine("The lottery numbers are {0}", string.Join(" ", drawnStr));
        }

        private static int RandomNumber()
        {
            Random rand = new System.Random();
            int newRand = rand.Next(1, 60); // return random number between 1 - 59
            return newRand;
        }

        private static int[] Draw()
        {
            int[] winningNums = new int[6];
            for (int i = 0; i < 6; i++)
            {
                winningNums[i] = RandomNumber();
            }

            return winningNums;
        }

    }
}
