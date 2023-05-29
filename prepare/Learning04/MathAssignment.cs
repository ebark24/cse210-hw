public class MathAssignment : Assignment
{
    private string _textBookSection = "";
    private string _problems = "";

    public MathAssignment(string StudentName, string Topic, string TextBookSection, string Problems) : base (StudentName, Topic)
    {
        _textBookSection = TextBookSection;
        _problems = Problems;
    }

    public string GetHomeworkList() 
    {
        return $"Section {_textBookSection} Problems {_problems}";
    }


}