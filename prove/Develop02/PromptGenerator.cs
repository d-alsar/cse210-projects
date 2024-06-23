public class PromptGenerator

{
    public List<string> _prompts;

    public PromptGenerator()
    {
        _prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did anything unexpected happen today that surprised me?",
            "What was the most challenging thing I faced today and how did I overcome it?",
            "What was the best moment of your day and why?",
            "Who did you share a special moment with today?",
            "Did you discover anything new or learn something interesting today?",
            "Did someone make you feel special or make you smile today?",
            "Did you achieve any success in your work, studies or personal projects today?",
            "Did you do anything today that took you out of your comfort zone?",
            "Did you receive any unexpected blessings today that you attribute to your faith? If so, can you describe them?",
        };
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}