using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        static void Main()
        {
            DisplayWelcome();
            string userName = PromptUserName();
            int userNumber = PromptUserNumber();
            int sqrNumber = SquareNumber(userNumber);
            DisplayResult(userName, sqrNumber);
        }

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }

        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userNum = Console.ReadLine();
            int favNum = int.Parse(userNum);
            return favNum;
        }

        static int SquareNumber(int PromptUserNumber)
        {
            return PromptUserNumber * PromptUserNumber;
        }

        static void DisplayResult(string userName, int sqrNumber)
        {
            Console.WriteLine($"{userName}, the square of your number is {sqrNumber}");
        }

        Main();
    }
}