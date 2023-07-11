public class Task
{
    protected string _completion = "Incomplete [ ]";

    protected string _stringRepresentation = "";

    public void CompleteTask(){
        _completion = "Complete [x]";
    }

    public string GetCompletion(){
        return _completion;
    }

    public string GetStringRepresentation()
    {
        return _stringRepresentation;
    }

    public virtual void SetStringRepreseenation(){}

    public virtual void DisplayTask(){}

}