using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine("Step 3:");
        Console.WriteLine(assignment.GetSummary());        
        Console.WriteLine();
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine("Step 4:");
        Console.WriteLine(mathAssignment.GetHomeworkList());
        Console.WriteLine();
        WritingAssignment writingAssignment = new WritingAssignment(
            "Mary Waters",
            "European History",
            "The Causes of World War II"
        );
        Console.WriteLine("Step 5:");
        Console.WriteLine(writingAssignment.GetWritingInformation());
    }
}
