using System;

class Program
{
    static void Main(string[] args)
    {
        Activity activity = new Activity("test", "this is a test");
        Console.WriteLine($"Hello {activity.GetName()}! This is the Mindfulness Project.");
    }
}