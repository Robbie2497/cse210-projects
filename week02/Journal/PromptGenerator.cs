public class PromptGenerator
{
    public List<string> _prompts;

    public string GetRandomPrompt()
    {
        List<string> _prompts = new List<string>
        {
            "What was the most meaningful moment of your day, and why did it stand out to you?",
            "How are you feeling in this moment, right now? Try to describe your emotions as clearly as possible",
            "What is one thing that challenged you today, no matter how small or big it may seem now?",
            "If you could change one thing about today, what would it be and why?"
        };
        Random random = new Random();
        int i = random.Next(0, _prompts.Count);
        return _prompts[i];
    }
}