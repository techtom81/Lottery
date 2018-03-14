using System;

namespace Lottery
{
    class LottoGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please pick 6 unique numbers from 1-59");
            if (System.Diagnostics.Debugger.IsAttached) Console.ReadLine();
            Console.WriteLine("Press any key to continue");
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
            string numbersStr = String.Join(",", numbersArr);
            Console.WriteLine("Thank you, your lottery numbers are {0}", numbersStr);
            
        }

        private static int RandomNumber()
        {
            Random rand = new System.Random();
            int newRand = rand.Next(1, 60); // return random number between 1 - 59
            return newRand;
        }

        private static int Draw()
        {
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(RandomNumber());
            }
        }

    }
}
