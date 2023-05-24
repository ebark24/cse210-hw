using System;

class Program
{
    static void Main(string[] args)
    {
        Reference Ref1 = new Reference();
        Ref1.setBook("Alma");
        Ref1.setVerseNumber("2-5");
        Ref1.setChapterNumber("5");
        string Final_ref = Ref1.getRefrence();
        Console.WriteLine(Final_ref);

        Word word1 = new Word();
        word1._word = "I";
        Word word2 = new Word();
        word2._word = "Like";
        Word word3 = new Word();
        word1._word = "Bannanas";
        Verse verse1 = new Verse();
        verse1._words.Add(word1);
        verse1._words.Add(word2);
        verse1.ConvertToVerse();
        verse1.DisplayVerse();

    }
}