public class Reference
{
    private string _book = "";

    private string _chapterNumber = "";
    private string _verseNumber = "";

    public void setBook(string book)
    {
        _book = book;
    }

    public void setVerseNumber(string verse)
    {
        _verseNumber = verse;
    }

        public void setChapterNumber(string chapterNumber)
    {
        _chapterNumber = chapterNumber;
    }


    public string getRefrence()
    {
        return _book + " " + _chapterNumber + ":"  + _verseNumber;
    }
}