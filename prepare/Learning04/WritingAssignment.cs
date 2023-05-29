public class WritingAssignment : Assignment
{
    private string _title = "";

    public WritingAssignment(string StudentName, string Topic, string Titel) : base(StudentName, Topic)
    {
        _title = Titel;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {_studentName}";
    }
}