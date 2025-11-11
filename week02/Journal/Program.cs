using System;
using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        int answer = 6;
        while (answer != 5)
        {
            Console.WriteLine("What would you like to do? ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            answer = int.Parse(Console.ReadLine());

            if (answer == 1)
            {
                string prompt = PromptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                string userAnswer = Console.ReadLine();
                Entry entry = new Entry();

                DateTime theCurrantDate = DateTime.Now;
                string date = theCurrantDate.ToShortDateString();
                entry._date = date;
                entry._promptText = prompt;
                entry._entryText = userAnswer;

                journal.AddEntry(entry);
            }

            if (answer == 2)
            {
                journal.DisplayAll();
            }
            
            if (answer == 3)
            {
                 Console.WriteLine("What file would you like load from?");
                string file = Console.ReadLine(); 

                journal.LoadFromFile(file);
            }



            if (answer == 4)
            {
                Console.WriteLine("What file would you like to save to? ");
                string file = Console.ReadLine();

                journal.SaveToFiles(file);
            }
        }
        
    }
}