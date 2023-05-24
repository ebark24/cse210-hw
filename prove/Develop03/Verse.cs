public class Verse
{
    private List<Word> _words = new List<Word>();
    private string _verse = "";

    public void ConvertToVerse()
    {
        foreach (Word w in _words)
        {
            string _wods = w.GetWord();
            _verse += $" {_wods}";
        }
    }
    public void ConvertToWords(string _v)
    {
        List<string> _ListOfWords = new List<string>(_v.Split(" "));
        foreach (string w in _ListOfWords)
        {
            Word _word1 = new Word();
            _word1.SetWord(w);
            _words.Add(_word1);
        }
    }

    public void DisplayVerse()
    {
        Console.WriteLine(_verse);
    }

}