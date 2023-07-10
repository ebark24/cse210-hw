public class Workout:Task
{
    private string _typeOfWorkout = "N/A";

    private int _duration = 0;

    public void AddWorkout(string Type, int Duration)
    {
        _typeOfWorkout = Type;
        _duration = Duration;
        if (_duration >= 45)
        {
            CompleteTask();
            Console.WriteLine("");
            Console.WriteLine("Congratulations you have completed this task!");
            Console.WriteLine("");
        }
    }

    public override void SetStringRepreseenation()
    {
        _stringRepresentation = $"Workout|{GetCompletion()}|{_typeOfWorkout}|{_duration}";
    }

    public override void DisplayTask()
    {
        Console.WriteLine($"You did a {_typeOfWorkout} workout for {_duration} minutes");
    }


}