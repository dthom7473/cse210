using System;
using System.IO;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string journalEntries = "JournalEntries.txt";
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine("1 - Write in Journal");
            Console.WriteLine("2 - View all Entries");
            Console.WriteLine("3 - Quit");

            int selection;
            if (int.TryParse(Console.ReadLine(), out selection))
            {
                switch (selection)
                {
                    case 1:
                        WriteJournalEntry(journalEntries);
                        break;
                    case 2:
                        ViewAllEntries(journalEntries);
                        break;
                    case 3:
                        keepRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You must input a number.");
            }
        }
    }
        static void WriteJournalEntry(string filePath)
        {
            PromptGenerator promptGenerator = new PromptGenerator();
            string prompt = promptGenerator.GetRandomPrompt();

            // Display and record the prompt and the user's entry
            Console.WriteLine($"{prompt}:");
            string userEntry = Console.ReadLine();

            Console.Write("Date (mm/dd/yyyy): ");
            string dateOfEntry = Console.ReadLine();

            // Append the new entry to the file
            using (StreamWriter outputFile = new StreamWriter(filePath, true))
            {
                outputFile.WriteLine($"Date: {dateOfEntry} - Prompt: {prompt}");
                outputFile.WriteLine(userEntry);
                outputFile.WriteLine(); // Add an empty line for separation
            }

            Console.WriteLine("Entry saved to file.");
        }

        static void ViewAllEntries(string filePath)
        {
            // Load and display entries using DataLoader
            DataLoader dataLoader = new DataLoader(filePath);
            dataLoader.LoadEntries();
        }

    
}