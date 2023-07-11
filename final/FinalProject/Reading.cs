public class Reading: Task
{
    private string _book = "N/A";
    private int _numberOfPagesRead = 0;
    private int _numberOfPagesRequired = 10;

    public Reading(){}

    public Reading(string Completion, string Book, int NumberOfPagesRead)
    {
        _completion = Completion;
        _book = Book;
        _numberOfPagesRead = NumberOfPagesRead;
    }

    public void RecordReading(string Book, int NumberOfPagesRead)
    {
        _book = Book;
        _numberOfPagesRead += NumberOfPagesRead;
        if (_numberOfPagesRead >= _numberOfPagesRequired)
        {
            CompleteTask();
            Console.WriteLine("");
            Console.WriteLine("Congratulations you have completed this task!");
            Console.WriteLine("");
        }
    }
    public override void DisplayTask()
    {
        Console.WriteLine($"You read {_numberOfPagesRead} pages of {_book}");
    }

    public override void SetStringRepreseenation()
    {
        _stringRepresentation = $"Reading|{GetCompletion()}|{_book}|{_numberOfPagesRead}";
    }
}