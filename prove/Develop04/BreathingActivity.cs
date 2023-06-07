public class BreathingActivity : Activity
{
    public void SetNameAndDescription()
    {
        SetActivityName("Breathing Activity");
        SetActivityDiscription("This activity will help you relax by walking you through breathing in and out slowly. Claer your mind and focus on your breathing");
    }
    public void DisplayActivity()
    {
        SetFutureTime();
        DateTime Start = GetStartTime();
        DateTime End = GetFutureTime();
        while (Start < End)
        {
            Start = DateTime.Now;
            Console.WriteLine("I like to eat pancakes");
        }

    }

}