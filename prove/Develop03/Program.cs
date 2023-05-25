using System;

class Program
{
    static void Main(string[] args)
    {
        Scriputre scriputre1 = new Scriputre("2 Nephi","2","27","Wherefore, men are afree according to the bflesh; and call things are dgiven them which are expedient unto man. And they are free to echoose fliberty and eternal glife, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be hmiserable like unto himself.");

        scriputre1.DisplayScripture();
        Console.WriteLine("");
        Console.WriteLine("Press Enter to continue or type 'Quit' to finish");

        string UserInput = "";

        while (UserInput != "Quit")
        {
            int WordsLeftToBeChanged = scriputre1.GetWordsToBeChangedCount();
            if (WordsLeftToBeChanged > 0)
            {
                UserInput = Console.ReadLine();
                Console.Clear();
                scriputre1.MakeMultipleBlanks();
                scriputre1.DisplayScripture();
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