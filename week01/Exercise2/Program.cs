using System;

class Program
{
    static void Main(string[] args)
    {
      
        Console.Write("What is the your grade percentage? ");
        string userInput = Console.ReadLine();
        int percentageGrade = int.Parse(userInput);
        string letterGrade;

        if (percentageGrade >= 90)
        {
            //Console.WriteLine("Your letter grade is an A");
            letterGrade = "A";
        }
        else if (percentageGrade >= 80)
        {
            //Console.WriteLine("Your letter grade is a B");
            letterGrade = "B";
        }
        else if (percentageGrade >= 70)
        {
            //Console.WriteLine("Your letter grade is a C");
            letterGrade = "C";
        }
        else if (percentageGrade >= 60)
        {
            //Console.WriteLine("Your letter grade is a D");
            letterGrade = "D";
        }
        else if (percentageGrade < 60)
        {
            //Console.WriteLine("Your letter grade is a F");
            letterGrade = "F";
        }
        else
        {
            letterGrade = "Invalid";
        }


        Console.Write(letterGrade);

        if (percentageGrade >= 70)
        {
            Console.WriteLine("Good job you passed this course! ");
        }
        else
        {
            Console.WriteLine("Im sorry you did not pass this course.");
        }
    }
}