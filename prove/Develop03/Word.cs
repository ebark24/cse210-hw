public class Word
{
    public string _word = "";

    public string ConvertToString()
    {
        return this._word;
    }

    public void SetWord(string word)
    {
      _word = word;
    }
    public string Change_To_Blank()
    {
        _word = "_";
        return _word;
    }
}