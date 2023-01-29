using System;
using System.Collections.Generic;
class Journal
{
    public string JournalFile = "Journal.txt";



public void Menu()
{
    string choice;
    do
    {
        choice = MenuAction();
        switch (choice)
        {
            case "1":
                DislpayJournal();
                break;
            case "2":
                DeleteJournal();
                break;
            case "3":
                AddEntry();
                break;

        }
    }
    while (choice != "4");

}



public string MenuAction()
{
    bool validChoice = false;
    string choice = "";

    do
    {
        System.Console.WriteLine("What would you like to do? ");
        System.Console.WriteLine("1. Read Journal ");
        System.Console.WriteLine("2. Delete Journal ");
        System.Console.WriteLine("3. Write in Journal ");
        System.Console.WriteLine("4. Close Journal ");

        choice = Console.ReadLine().Trim();

        if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
        {
            validChoice = true;
        }
        else
        {
            System.Console.WriteLine("I'm sorry but that is an invalid choice. Please select 1-4 from the menu, thank you!");
        }

    } 
    
    while (!validChoice);
    return choice;
}



public void CreateFile()
{
    if (!System.IO.File.Exists(JournalFile))
    {
        File.CreateText(JournalFile);
    }
}



public void DislpayJournal()
{
    System.Console.WriteLine("Welcome to your journal! Write in me some more! ");
    
    string entries = File.ReadAllText(JournalFile);
    System.Console.WriteLine(entries);

}



public void AddEntry()
{
    System.Console.WriteLine("What's on your mind today? (Type 'thanks' when you're done) ");

    string journalEntry = "";
    bool keepGoing = true;
    while (keepGoing)
    {
        string line = Console.ReadLine();
        if (line.ToLower() == "thanks")
        {
            keepGoing = false;
        }
        else
        {
            journalEntry += line;
        }
    }
    File.AppendAllText(JournalFile, $"Entry: {journalEntry}");
    System.Console.WriteLine("Your Journal has been updated! ");

    return;
}



public void DeleteJournal()
{
File.WriteAllText(JournalFile, String.Empty);
System.Console.WriteLine("All data in your Journal has been cleared. ");

return;
}
}
