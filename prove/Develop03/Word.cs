public class Word
{
    private string _word = "";

    public string ConvertToString()
    {
        return this._word;
    }
    public string Change_To_Blank()
    {
        _word = "_";
        return _word;
    }
}