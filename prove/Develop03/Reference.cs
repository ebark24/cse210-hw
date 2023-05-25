public class Reference
{
    private string _book = "";

    private string _chapterNumber = "";
    private string _verseNumber = "";

    public Reference(string book,string chapterNumber, string verse)
    {
        _book = book;
        _chapterNumber = chapterNumber;
        _verseNumber = verse;
    }
    public Reference(string book,string chapterNumber, string beginingVerse, string endingVerse)
    {
        _book = book;
        _chapterNumber = chapterNumber;
        _verseNumber = $"{beginingVerse}-{endingVerse}";
    }

    public void SetBook(string book)
    {
        _book = book;
    }

    public void SetVerseNumber(string verse)
    {
        _verseNumber = verse;
    }


        public void SetChapterNumber(string chapterNumber)
    {
        _chapterNumber = chapterNumber;
    }


    public string GetRefrence()
    {
        return _book + " " + _chapterNumber + ":"  + _verseNumber;
    }
}