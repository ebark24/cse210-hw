public class ImaginationActivity : Activity
{
    private List<string> _places = new List<string>{
        "at the beach",
        "at the top of a mountain",
        "at a waterfall",
        "in the middle of a wide field",
    };

    private List<string> _questions = new List<string>{
        "What does it feel like to be there?",
        "What kinds of things do you see?",
        "What do you smell?",
        "Are you happy to be here?",
        "What kind of sensations are you feeling?"
    };
    public void SetNameAndDescription()
    {
        SetActivityName("Imagination Activity");
        SetActivityDiscription("This activity will help you relax by briging you to an imaginary place and reflectiong on what that place might be like.");
    }

    public string ReturnRandomPlace()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_places.Count);
        string randomPlace = _places[randIndex];
        return randomPlace;
    }

    public void DisplayRandomQuestion()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_questions.Count);
        string randomQuestion = _questions[randIndex];
        Console.WriteLine(randomQuestion);
    }

    public void DisplayActivity(){
        Console.WriteLine("");
        Console.WriteLine($"Imagine you are {ReturnRandomPlace()}");
        Console.WriteLine("Once you have this place in mind, press enter");
        Console.ReadLine();
        Console.WriteLine("Now consider the follwoing questions:");
        DisplayWaitingAnimation();

        DateTime Start = DateTime.Now;
        DateTime End = Start.AddSeconds(GetUserDuration());

        while (Start <= End)
        {
            DisplayRandomQuestion();
            DisplayWaitingAnimation();
            Start = DateTime.Now;
        }
    }
}