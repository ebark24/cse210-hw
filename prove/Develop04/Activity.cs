public class Activity
{
    private string _activityName = "";
    private string _activityDiscription = "";
    private int _activityDuration = 6;

    public Activity(string ActivityName, string ActivityDiscription)
    {
        _activityName = ActivityName;
        _activityDiscription = ActivityDiscription;
    }

    public void DisplayOpeningMessage()
    {
        Console.WriteLine($"Welcome to {_activityName}\n");
        Console.WriteLine(_activityDiscription);
    }

    public void SetUserDuration()
    {
        Console.WriteLine($"\nHow long, in seconds, would you like for your session");
        int Userinput = int.Parse(Console.ReadLine());
        _activityDuration = Userinput;
        Console.WriteLine(_activityDuration);
    }

    public void DispalyClosingMessage()
    {
        Console.WriteLine("Well Done\n");
        Console.WriteLine($"You have completed a {_activityName} for {_activityDuration}");
    }
}