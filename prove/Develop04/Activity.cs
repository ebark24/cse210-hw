public class Activity
{
    private string _activityName = "";
    private string _activityDiscription = "";
    private int _activityDuration = 6;


    public void DisplayOpeningMessage()
    {
        Console.WriteLine($"Welcome to {_activityName}\n");
        Console.WriteLine(_activityDiscription);
    }

    public void SetActivityName(string activityName)
    {
        _activityName = activityName;
    }

    
    public void SetActivityDiscription(string activityDiscription)
    {
        _activityDiscription = activityDiscription;
    }


    public void SetUserDuration()
    {
        Console.WriteLine($"\nHow long, in seconds, would you like for your session");
        int Userinput = int.Parse(Console.ReadLine());
        _activityDuration = Userinput;
    }

    public int GetUserDuration()
    {
        return _activityDuration;
    }

    public void DisplayOpeningAnimation()
    {
        Console.Clear();
        Console.Write("Geting Ready |");
        DisplayWaitingAnimation();
    }

    public void DisplayClosingAnimation()
    {
        Console.Write("Well Done! |");
        DisplayWaitingAnimation();
    }

    public void DisplayWaitingAnimation()
    {

        for (int i = 0; i <5; i++)
        {
            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("-");

            Thread.Sleep(500);
            Console.Write("\b \b");
            Console.Write("|");
        } 
        Console.Write("\b \b"); 
    }

    public void DispalyClosingMessage()
    {
        Console.WriteLine("");
        Console.WriteLine($"You have completed a {_activityName} for {_activityDuration} seconds");
    }
}