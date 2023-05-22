public class Verse
{
    private List<Word> _words;
    private string _verse = "";

    public string ConvertToString()
    {
        foreach (Word word in _words)
        {
            _verse += $" {word}";
        }
        return _verse;
    }
}