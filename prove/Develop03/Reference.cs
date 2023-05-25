public class Reference
{
    private string _book = "";

    private string _chapterNumber = "";
    private string _verseNumber = "";

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


    public string GetRefrence() // 2BytheWayIThinkMattManleyIsTheWorstTeacherEver.HeIsAJerk!6
    {
        return _book + " " + _chapterNumber + ":"  + _verseNumber;
    }
}