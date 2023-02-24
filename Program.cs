using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void IntroductionToGame()
        {
            Console.WriteLine();
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hello. Let's play a game.");
            Console.WriteLine();
            Console.WriteLine("You pick a number between 1 and 1024 and I will guess it. Tell me if my number is HIGHER, LOWER, or CORRECT.");
            Console.WriteLine();
            Console.WriteLine("Are you ready? Lets Begin!");
            Console.WriteLine("-----------------------------------------");
        }
        static int GuessANewNumber(int newLowNumber, int newHighNumber)
        {
            var randomNumberGenerator = new Random();
            var randomNumber = randomNumberGenerator.Next(newLowNumber, newHighNumber);
            Console.WriteLine($"I will guess between {newLowNumber} and {newHighNumber}. ");
            randomNumber = randomNumberGenerator.Next(newLowNumber, newHighNumber);
            Console.Write($"Is your number {randomNumber}? ");
            return randomNumber;
        }
        static void Brag(int aNumber)
        {
            Console.WriteLine($"MuAhahahaha! I knew your number is {aNumber}!");

        }
        static void Main(string[] args)
        {
            IntroductionToGame();

            var newHighestNumber = 1024;
            var newLowestNumber = 1;
            var randomNumber = GuessANewNumber(newLowestNumber, newHighestNumber);
            var userInput = Console.ReadLine();

            while (userInput != "CORRECT")
            {

                switch (userInput)
                {
                    case "HIGHER":
                        newLowestNumber = randomNumber + 1;
                        randomNumber = GuessANewNumber(newLowestNumber, newHighestNumber);
                        userInput = Console.ReadLine();
                        break;
                    case "LOWER":
                        newHighestNumber = randomNumber - 1;
                        randomNumber = GuessANewNumber(newLowestNumber, newHighestNumber);
                        userInput = Console.ReadLine();
                        break;
                    default:
                        Console.Write($"404. Does not compute. Is your number {randomNumber} ");
                        userInput = Console.ReadLine();
                        break;
                }
            }

            Brag(randomNumber);












        }
    }
}

