﻿using System;
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
            String userInput;
            int[] pickedNumbers = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Pick a number");
                userInput = Console.ReadLine();

                if (Int32.TryParse(userInput, out int tempPickedNumber))
                {
                    if (tempPickedNumber > 0 && tempPickedNumber < 60)
                    {
                        if (Array.IndexOf(pickedNumbers, tempPickedNumber) < 0) {
                            pickedNumbers[i] = tempPickedNumber;
                        }
                        else
                        {
                            Console.WriteLine("Number already picked, try again.");
                            i--;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Number must be between 1 and 59, try again.");
                        i--;                                             
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid number, try again.");
                    i--;
                }                
            }
            Array.Sort(pickedNumbers);
            string numbersStr = string.Join(" ", pickedNumbers);
            Console.WriteLine("Thank you, your lottery numbers are {0}", numbersStr);
            Console.WriteLine("Press any key to start the draw, Good luck!");
            Console.ReadLine();
            int[] drawnNumbers = Draw();
            Array.Sort(drawnNumbers);
            List<string> drawnStr = new List<string>();
            List<string> matchedNums = new List<string>();
            foreach (int number in drawnNumbers)
            {
                drawnStr.Add(number.ToString());
            }
            Console.WriteLine("The lottery numbers are {0}", string.Join(" ", drawnStr));
            Console.WriteLine(Compare(pickedNumbers, drawnNumbers));
        }


        // Generate and return 1 random number between 1 - 59
        private static int RandomNumber()
        {
            Random rand = new System.Random();
            int newRand = rand.Next(1, 60);
            return newRand;
        }


        // Fill and return array with 6 unique random numbers generated by RandomNumber()
        private static int[] Draw()
        {
            int[] winningNums = new int[6];
            for (int i = 0; i < 6; i++)
            {
                int newRandomNumber = RandomNumber();
                // Check number isn't already in array before adding it
                if (Array.IndexOf(winningNums, newRandomNumber) < 0 )
                {
                    winningNums[i] = newRandomNumber;
                }
                else
                {
                    i--;
                }
            }

            return winningNums;
        }


        // Compare pickedNumbers to drawnNumbers and return result message
        private static string Compare(int[] picked, int[] drawn)
        {
            string message;
            List<string> matchedNums = new List<string>();

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (picked[i] == drawn[j])
                    {
                        matchedNums.Add(picked[i].ToString());
                    }
                }
            }
            int matchedTotal = matchedNums.Count;
            if (matchedTotal > 0 && matchedTotal < 6)
            {
                message = "Congratulations! you matched " + matchedTotal.ToString() + " numbers";
                message += " Your matched numbers are: " + string.Join(" ", matchedNums);
            }
            else if (matchedTotal == 6)
            {
                message = "Congratulations you won the jackpot! You matched all 6 numbers";
            }
            else
            {
                message = "Unlucky! you didn't match any numbers";
            }

            return message;
        }

    }
}
