using System;

namespace Lottery
{
    class Program
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
            Console.WriteLine("Thank you, your lottery numbers are "+numbersStr);
        }
    }
}
