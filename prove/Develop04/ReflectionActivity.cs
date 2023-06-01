public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _questions;

    public void DisplayRandomPrompt()
    {
        Random rnd = new Random();
        int randIndex = rnd.Next(_prompts.Count);
        string randomPrompt = _prompts[randIndex];
        Console.WriteLine(randomPrompt);
    }
}