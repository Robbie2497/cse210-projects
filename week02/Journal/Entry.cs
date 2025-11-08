public class Entry
{
    public string _date;
    public string _prompt;
    public string _response;

// For exceeding requirements, I added in a scripture to go along with the journal entry if the user wants to enter one.
    public string _scripture;

    public void Display()
    {
        Console.WriteLine($"Date: {_date} — Prompt: {_prompt}");
        Console.WriteLine($"Your response: {_response}");
        Console.WriteLine();
        if (_scripture != "")
        {
            Console.WriteLine(_scripture);
        }
        else
        {
            Console.WriteLine($"Scripture along with entry: {_scripture}");
        }
        Console.WriteLine();
    }
}