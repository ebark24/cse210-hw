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
    }
}