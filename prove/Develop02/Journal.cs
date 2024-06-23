using System;
using System.Collections.Generic;

namespace DailyJournal
{
    public class Journal
    {
        private List<Entry> entries;

        public Journal()
        {
            entries = new List<Entry>();
        }

        public void AddEntry(Entry entry)
        {
            entries.Add(entry);
        }

        public void DisplayEntries()
        {
            foreach (var entry in entries)
            {
                Console.WriteLine(entry.ToString());
            }
        }

        public void SaveToFile()
        {
            Console.Write("Enter Filename: ");
            string filename = Console.ReadLine();

            try
            {
                using (var writer = new System.IO.StreamWriter(filename))
                {
                    writer.WriteLine("Date|Prompt|Response");


                    foreach (Entry entry in entries)
                    {
                        writer.WriteLine($"{entry.Date}|{entry.PromptText}|{entry.EntryText}");
                    }
                }

                Console.WriteLine("Entries saved to file.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving to file: {ex.Message}");
            }
        }

public void LoadFromFile()
{
    Console.Write("Enter filename: ");
    string filename = Console.ReadLine();
    entries.Clear();

    try
    {
        using (var reader = new StreamReader(filename))
        {
            string headerLine = reader.ReadLine(); // Read and discard the header line

            while (!reader.EndOfStream)
            {
                string entryLine = reader.ReadLine();
                string[] fields = entryLine.Split('|');

                if (fields.Length >= 3)
                {
                    string date = fields[0];
                    string prompt = fields[1];
                    string response = fields[2];

                    entries.Add(new Entry(date, prompt, response));
                }
            }
        }

        Console.WriteLine("Entries loaded from file.");
    }
    catch (FileNotFoundException)
    {
        Console.WriteLine("File not found.");
    }
    catch (IOException ex)
    {
        Console.WriteLine($"Error reading file: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading from file: {ex.Message}");
    }
}

    }
}
