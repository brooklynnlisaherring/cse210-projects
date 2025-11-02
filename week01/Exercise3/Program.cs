using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //int magicNumber = int.Parse(Console.ReadLine());
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine()); 

            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
        }    
        if (guess == magicNumber)
        {
            Console.Write("Great job! You guessed the number"); 
        }
        else
        {
            Console.Write("Oops somthing went wrong. Try again! ");
        }
    }
}