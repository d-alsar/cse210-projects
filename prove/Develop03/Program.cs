using System;

namespace DailyScripture
{
    class Program
    {
        static void Main()
        {
            var scriptures = new List<Scripture>
            {
                new Scripture("Isaiah", 1, 18, "Come now, and let us reason together, saith the Lord: though your sins be as scarlet, they shall be as white as snow; though they be red like crimson, they shall be as wool."),
                new Scripture("John", 17, 3, "And this is life eternal, that they might know thee the only true God, and Jesus Christ, whom thou hast sent."),
                new Scripture("Moses", 7, 18, "And the Lord called his people Zion, because they were of one heart and one mind, and dwelt in righteousness; and there was no poor among them."),
                new Scripture("D&C", 25, 13, "Wherefore, lift up thy heart and rejoice, and cleave unto the covenants which thou hast made."),
                new Scripture("Alma", 32, 21, "And now as I said concerning faith—faith is not to have a perfect knowledge of things; therefore if ye have faith ye hope for things which are not seen, which are true.")
            };

            Random random = new Random();
            Scripture randomScripture = scriptures[random.Next(scriptures.Count)];

            Console.Clear();
            randomScripture.Display();
            Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "quit")
                {
                    Console.WriteLine("\nGoodbye! Keep up the great work and see you next time!\n");
                    break;
                }

                randomScripture.HideRandomWord();

                if (randomScripture.AllWordsHidden())
                {
                    Console.Clear();
                    randomScripture.Display();
                    Console.WriteLine("Congrats! You have memorized the scripture!\n");
                    break;
                }

                Console.Clear();
                randomScripture.Display();
                Console.WriteLine("\nPress Enter to continue or type 'quit' to exit.");
            }
        }
    }
}