using System;

class Program
{
    static void Main(string[] args)
    {
        List<Scriputre> SctiptureList = new List<Scriputre>();
        Scriputre scriputre1 = new Scriputre("2 Nephi","2","27","Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.");
        Scriputre scriputre2 = new Scriputre("Jeramiah","17","7","Blessed is the man that trusteth in the Lord, and whose hope the Lord is.");
        Scriputre scriputre3 = new Scriputre("Matthew","11","28","30","Come unto me, all ye that labour and are heavy laden, and I will give you rest. Take my yoke upon you, and learn of me; for I am meek and lowly in heart: and ye shall find rest unto your souls. For my yoke is easy, and my burden is light");
        Scriputre scriputre4 = new Scriputre("1 John","3","2","3","Beloved, now are we the sons of God, and it doth not yet appear what we shall be: but we know that, when he shall appear, we shall be like him; for we shall see him as he is. And every man that hath this hope in him purifieth himself, even as he is pure.");
        SctiptureList.Add(scriputre1);
        SctiptureList.Add(scriputre2);
        SctiptureList.Add(scriputre3);
        SctiptureList.Add(scriputre4);

        Random rnd = new Random();
        int randIndex = rnd.Next(SctiptureList.Count);
        Scriputre randomScripture = SctiptureList[randIndex];
        
        
        Console.Clear();
        randomScripture.DisplayScripture();
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'Quit' to finish");

        string UserInput = "";

        while (UserInput != "Quit")
        {
            int WordsLeftToBeChanged = randomScripture.GetWordsToBeChangedCount();
            if (WordsLeftToBeChanged > 0)
            {
                UserInput = Console.ReadLine();
                Console.Clear();
                randomScripture.MakeMultipleBlanks();
                randomScripture.DisplayScripture();
                Console.WriteLine("");
                Console.WriteLine("Press Enter to continue or type 'Quit' to finish");
            }
            else
            {
                UserInput = "Quit";
            }

        }
    }
}