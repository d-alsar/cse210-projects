using System;

namespace DailyJournal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to the Journal Program!");// added outside to not be displayed everytime the user is asked what would you like to do.

            bool quit = false;
            PromptGenerator promptGenerator = new PromptGenerator();
            Journal journal = new Journal(); // Instantiate the Journal class

            while (!quit)
            {
             
                Console.WriteLine("Please Select one of the following choices:");
                Console.WriteLine("1. Write");
                Console.WriteLine("2. Display");
                Console.WriteLine("3. Save");
                Console.WriteLine("4. Load");
                Console.WriteLine("5. Quit");

                Console.WriteLine("\nWhat would you like to do? ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string randomPrompt = promptGenerator.GetRandomPrompt();
                        Console.WriteLine($"Prompt: {randomPrompt}");
                        Console.WriteLine("Enter your response:");
                        string response = Console.ReadLine();
                        Entry newEntry = new Entry(DateTime.Now.ToString("yyyy-MM-dd"), randomPrompt, response);//added date time now to get current date
                        journal.AddEntry(newEntry);
                        break;
                    case "2":
                        Console.WriteLine("\n--- Displaying Entries ---");//added this to make the display understandable by the user
                        journal.DisplayEntries();
                        break;
                    case "3":
                        journal.SaveToFile();
                        break;
                    case "4":
                        journal.LoadFromFile();
                        Console.WriteLine("\n--- Displaying Loaded Entries ---");
                        journal.DisplayEntries(); // Display loaded entries after loading
                        break;
                    case "5":
                        quit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice."); //added this in case the user enter a value different than the choices displayed
                        break;
                }
            }

            Console.WriteLine("Until next time, keep writing!");
        }
    }
}
