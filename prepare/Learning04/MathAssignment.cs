

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

// i did not include string studentName and topic at first
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHwList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }

}