public class Resume
{
    public string _name;
    public List<Job> _jobsList = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine($"Jobs:");
        foreach (Job j in _jobsList)
        {
            j.Display();
        }
    }
}
