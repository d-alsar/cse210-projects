using System;

namespace DailyJournal
{
    public class Entry
    {
        public string Date { get; private set; }
        public string PromptText { get; private set; }
        public string EntryText { get; private set; }

        public Entry(string date, string promptText, string entryText)
        {
            Date = date;
            PromptText = promptText;
            EntryText = entryText;
        }

        public override string ToString()
        {
            return $"Date: {Date} - Prompt: {PromptText}\n{EntryText}\n";
        }
    }
}
