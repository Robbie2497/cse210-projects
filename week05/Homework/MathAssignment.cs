using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

        public MathAssignment(string StudentName, string topic, string textbookSection, string problems) : base(
            StudentName,
            topic
        )
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetStudentName()} - {GetTopic()}\nSection {_textbookSection} Problems {_problems}";
    }

    public string GetTextbooxSection()
    {
        return _textbookSection;
    }

    public void SetTextbookSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProlems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }
}
