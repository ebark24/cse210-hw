public class ListingActivity : Activity
{
    List<string> _prompts = new List<string> {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    List<string> _responses = new List<string>();

    public void SetNameAndDescription()
    {
        SetActivityName("Listing Activity");
        SetActivityDiscription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
    }

    public void DisplayRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        Console.WriteLine(randomPrompt);
    }

    public void GetResponse()
    {
        string Response = Console.ReadLine();
        _responses.Add(Response);
    }

    public int GetNumberOfResponses()
    {
        return _responses.Count();
    }

    public void DisplayActivity()
    {
        DateTime Start = DateTime.Now;
        DateTime End = Start.AddSeconds(GetUserDuration());
        Console.WriteLine("");
        Console.WriteLine("List as many responses as you can for the folling prompt:");
        DisplayRandomPrompt();

        while (Start <= End)
        {
            GetResponse();
            Start = DateTime.Now;
        }
        Console.WriteLine($"You listed {GetNumberOfResponses()} items!");

    }
}