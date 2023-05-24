public class Word
{
    private string _word = "";

    public string ConvertToString()
    {
        return this._word;
    }

    public string GetWord()
    {
        return _word;
    }

    public void SetWord(string word)
    {
      _word = word;
    }
    public string Change_To_Blank()
    {
        int letters = _word.Count();
        _word = "";
        for (int i=0; i<letters; i++)
        {
            _word += "_";
        }
        return _word;
    }
}