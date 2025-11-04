using System;
using System.Reflection.Metadata;

class Program
{

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }
    static string PromptUserForName()
    {
        Console.Write("What's is your name? ");
        string usersName = Console.ReadLine();
        return usersName;
    }
    static int PromptUserNumber()
    {
        Console.Write("What is your favorit number? ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }
    static int SquareNumber(int theNumber)
    {
        int square = theNumber * theNumber;
        return square;
    }
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello World! This is the Exercise5 Project.");
        DisplayWelcome();
        string name = PromptUserForName();
        int number = PromptUserNumber();
        int sqNumber = SquareNumber(number);
        Console.Write($"{name}, the square of your number is {sqNumber}");
    }
}