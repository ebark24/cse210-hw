public class BreathingActivity : Activity
{
    public void SetNameAndDescription()
    {
        SetActivityName("Breathing Activity");
        SetActivityDiscription("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing");
    }

    public void BreathingIn()
    {
        Console.WriteLine("");
        Console.WriteLine("Breathe in...");
    }

    public void Countdown()
    {
        Console.Write("3");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("2");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("1");
        Thread.Sleep(1000);
        Console.Write("\b \b");
        Console.Write("");
    }

    public void BreathingOut()
    {
        Console.WriteLine("");
        Console.WriteLine("Now breathe out...");
    }
    public void DisplayActivity()
    {
        DateTime Start = DateTime.Now;
        DateTime End = Start.AddSeconds(GetUserDuration());
        while (Start <= End)
        {
            BreathingIn();
            Countdown();
            BreathingOut();
            Countdown();
            Start = DateTime.Now;
        }

    }

}