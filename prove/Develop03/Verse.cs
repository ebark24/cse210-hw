public class Verse
{
    private List<Word> _words = new List<Word>();
    private string _verse = "";

    public void ConvertToVerse()
    {
        _verse = " ";
        foreach (Word w in _words)
        {
            string word = w.GetWord();
            _verse += $" {word}";
        }
    }
    public void ConvertToWords()
    {
        List<string> _ListOfWords = _verse.Split(" ").ToList();
        foreach (string w in _ListOfWords)
        {
            Word _word1 = new Word();
            _word1.SetWord(w);
            _words.Add(_word1);
        }
    }
    public void RandomBlanks()
    {
        int WordsToBeChanged = 3;
        for (int i=0; i<WordsToBeChanged; i++)
        {
            Random rnd = new Random();
            int randIndex = rnd.Next(_words.Count);
            Word randomWord = _words[randIndex];
            string Ranword = randomWord.GetWord();
            randomWord.Change_To_Blank();
        }

    }

    public void SetVerse(string verse)
    {
        _verse = verse;
    }

    public string GetVerse()
    {
        return _verse;
    }

}