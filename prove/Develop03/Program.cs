using System;
using System.IO;

class Journal
{
    public string Prompt { get; set; }
    public string Response { get; set; }
    public DateTime Date { get; set; }
    public string JournalFile = "Journal.txt";
}

class Program
{
    static List<string> prompts = new List<string> {
        "How did you serve someone today? ",
        "Did you come closer to Christ? ",
        "What's something you would have changed from today? ",
        "What do you plan on doing this weekend? ",
        "What did you study in your scriptures today? "
    };
    static List<Journal> journal = new List<Journal>();

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Write a New Entry. ");
            Console.WriteLine("2. Display the Journal. ");
            Console.WriteLine("3. Save Journal to a file. ");
            Console.WriteLine("4. Delete the Journal. ");
            Console.WriteLine("5. Exit. ");

            string choice = Console.ReadLine();
            if (choice == "1")
            {
                AddEntry();
            }
            else if (choice == "2")
            {
                DisplayJournal();
            }
            else if (choice == "3")
            {
                Console.Write("Enter the filename: ");
                string fileName = Console.ReadLine();
                // SaveJournal();
            }
            else if (choice == "4")
            {
                // DeleteJournal();
            }
            else if (choice == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }
    }

    static void AddEntry()
    {
        Random randomPrompt = new Random();
        int index = randomPrompt.Next(prompts.Count);
        string prompt = prompts[index];

        Console.Write(prompt + " ");
        string response = Console.ReadLine();
        
        Journal entry = new Journal
        {
            Prompt = prompt,
            Response = response,
            Date = DateTime.Now
        };

        journal.Add(entry);
    }

    static void DisplayJournal()
    {
        foreach (Journal entry in journal)
        {
            Console.WriteLine("Prompt: " + entry.Prompt);
            Console.WriteLine("Response: " + entry.Response);
            Console.WriteLine("Date: " + entry.Date);
        }
    }

    // static void SaveJournal()
    // {
    //     File.AppendAllText(JournalFile);
    // }

    // static void DeleteJournal()
    // {
    //     File.WriteAllText(JournalFile, String.Empty);
    //     System.Console.WriteLine("All contents of your Journal has been cleared. ");
    // }
}