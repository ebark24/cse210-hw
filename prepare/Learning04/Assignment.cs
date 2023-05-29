public class Assignment
{
    protected string _studentName = "";
    private string _topic = "";

    public Assignment(string StudentName, string Topic)
    {
        _studentName = StudentName;
        _topic = Topic;
    }

    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }

}