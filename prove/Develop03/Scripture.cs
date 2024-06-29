using System;

namespace DailyScripture
{
    class Scripture
    {
        public Reference Reference { get; private set; }
        private List<Word> Words { get; set; }
        private Random random;

        public Scripture(string book, int chapter, int verse, string text)
        {
            Reference = new Reference(book, chapter, verse);
            Words = text.Split(' ').Select(word => new Word(word)).ToList();
            random = new Random();
        }

        public void Display()
        {
            Console.WriteLine(Reference.ToString());
            foreach (var word in Words)
            {
                if (word.IsHidden)
                {
                    Console.Write(new string('_',word.Text.Length)+" ");
                }
                else
                {
                    Console.Write(word.Text+ " ");
                }
            }
            Console.WriteLine();
        }

        public bool HideRandomWord()
        {
            var visibleWords = Words.Where(word => !word.IsHidden).ToList();
            if (visibleWords.Count == 0) return false;

            var wordToHide = visibleWords[random.Next(visibleWords.Count)];
            wordToHide.Hide();
            return true;
        }

        public bool AllWordsHidden()
        {
            return Words.All(word => word.IsHidden);
        }
    }
}
