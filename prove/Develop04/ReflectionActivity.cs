public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

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
}