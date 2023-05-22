public class Scriputre
{
    private Verse _verse = new Verse();
    private Reference _refrence = new Reference();

    public void DisplayScripture()
    {
        Console.WriteLine($"{_refrence} {_verse}");
    }
}