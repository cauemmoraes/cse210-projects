using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,100);

        int guessNumber = -1;

        while (number != guessNumber)
        {
            Console.Write("What is your guess? ");
            string userNumber = Console.ReadLine();
            guessNumber = int.Parse(userNumber);

            if (guessNumber < number)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber > number)
            {
                Console.WriteLine("Lower");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}