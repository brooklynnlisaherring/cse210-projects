using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int userNumber = 9;
        List<int> numbers = new List<int>();

        //making the list
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            userNumber = int.Parse(Console.ReadLine());
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }
        int total = 0;
        int largest = numbers[0];
        // finding total
        foreach (int num in numbers)
        {
            total += num;
        }
        //amount of numbers in list
        int count = numbers.Count;
        // the average of the numbers
        float average = total / count;
        //finding the largest number
        foreach (int num in numbers)
        {
            if (num > largest)
            {
                largest = num;
            }
        }
        //printig results
        Console.WriteLine($"the sum is: {total}");
        Console.WriteLine($"the averge is: {average}");
        Console.WriteLine($"the largest number is: {largest}");
    }
}