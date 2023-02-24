using System;
using System.Collections.Generic;

namespace NumberGuesser
{
    class Program
    {
        static void IntroductionToGame()
        {
            Console.WriteLine("/n");
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Hello. Let's play a game.");
            Console.WriteLine("/n");
            Console.WriteLine("You pick a number between 1 and 1024 and I will guess it. Tell me if my number is HIGHER, LOWER, or CORRECT.");
            Console.WriteLine("/n");
            Console.WriteLine("Are you ready? Lets Begin!");
            Console.WriteLine("-----------------------------------------");
        }
        static void Brag(int randomNumber)
        {
            Console.WriteLine($"MuAhahahaha! I knew your number is {randomNumber}!");

        }
        static void Main(string[] args)
        {
            IntroductionToGame();

            var newHighestNumber = 1024;
            var newLowestNumber = 1;
            var randomNumberGenerator = new Random();
            var randomNumber = randomNumberGenerator.Next(newLowestNumber, newHighestNumber);

            Console.Write($"Is your number {randomNumber}? ");

            var userInput = Console.ReadLine();

            while (userInput != "CORRECT")
            {

                switch (userInput)
                {
                    case "HIGHER":
                        newLowestNumber = randomNumber + 1;
                        Console.WriteLine($"Okay Fine... Next I will guess between {newLowestNumber} and {newHighestNumber}. ");
                        randomNumber = randomNumberGenerator.Next(newLowestNumber, newHighestNumber);
                        Console.Write($"Is your number {randomNumber}? ");
                        userInput = Console.ReadLine();
                        break;
                    case "LOWER":
                        newHighestNumber = randomNumber - 1;
                        Console.WriteLine($"Okay Fine... Next I will guess between {newLowestNumber} and {newHighestNumber}. ");
                        randomNumber = randomNumberGenerator.Next(newLowestNumber, newHighestNumber);
                        Console.Write($"Is your number {randomNumber}? ");
                        userInput = Console.ReadLine();
                        break;
                    default:
                        Console.Write($"404. Does not compute. Is your number {randomNumber} ");
                        userInput = Console.ReadLine();
                        break;
                }

                Brag(randomNumber);

            }












        }
    }
}

