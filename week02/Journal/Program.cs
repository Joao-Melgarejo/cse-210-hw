using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();
        string choice = "";

        Console.WriteLine("Welcome to your journal!");

        while (choice != "5")
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the jorunal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Quit");
            Console.WriteLine("Choose an option: ");
            choice = Console.ReadLine();
            Console.WriteLine();

            if (choice == "1")
            {
                string Prompt = generator.GetRandomPrompt();
                Console.WriteLine(Prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry
                {
                    _date = DateTime.Now.ToString("yyyy-MM-dd"),
                    _prompt = Prompt,
                    _response = response
                };

                journal.AddEntry(entry);
                Console.WriteLine("Entry added.");
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("Enter a filename to save.");
                string filename = Console.ReadLine();
                journal.SaveToFile(filename);
            }
            else if (choice == "4")
            {
                Console.WriteLine("Enter a filename to load");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye, see you later!");
            }
            else
            {
                Console.WriteLine("Invalid option. Please Try again.");
            }
        }
    }
}