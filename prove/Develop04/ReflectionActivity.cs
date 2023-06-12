public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>{
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };
    private List<string> _questions = new List<string> {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

        public void SetNameAndDescription()
    {
        SetActivityName("Relfection Activity");
        SetActivityDiscription("This Activity will help you reflect on times in your life when you have shown streagth and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
    }

    public void DisplayRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        Console.WriteLine(randomPrompt);
    }

    public void DisplayRandomQuestion()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_questions.Count);
        string randomQuestion = _questions[randIndex];
        Console.WriteLine(randomQuestion);
    }

    public void DisplayActivity()
    {
        DateTime Start = DateTime.Now;
        DateTime End = Start.AddSeconds(GetUserDuration());
        Console.WriteLine("");
        Console.WriteLine("Consider the following prompt:");
        DisplayRandomPrompt();
        DisplayWaitingAnimation();
        
        Console.WriteLine("Now consider the follwoing questions:");
        DisplayWaitingAnimation();

        while (Start <= End)
        {
            DisplayRandomQuestion();
            DisplayWaitingAnimation();
            Start = DateTime.Now;
        }

    }
}