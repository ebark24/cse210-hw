public class Verse
{
    public List<Word> _words = new List<Word>();
    public string _verse = "";

    public void ConvertToVerse()
    {
        foreach (Word w in _words)
        {
            string _wods = w._word;
            _verse += $" {_wods}";
        }
    }
    public void ConvertToWords(string _verse)
    {
        List<string> _ListOfWords = new List<string>(_verse.Split(" "));
        Word _word1 = new Word();
        _words.Add(_word1);
        foreach (string w in _ListOfWords)
        {
            _word1.SetWord(w);
            _words.Add(_word1);
        }
    }

    public void DisplayVerse()
    {
        Console.WriteLine(_verse);
    }

}