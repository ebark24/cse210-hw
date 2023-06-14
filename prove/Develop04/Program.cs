using System;

class Program
{
    static void Main(string[] args)
    {
        string Userinput = "0";
        while (Userinput != "5")
        {
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1.Start Breathing Activity");
            Console.WriteLine("2.Start Reflection Activity");
            Console.WriteLine("3.Start Listing Activity");
            Console.WriteLine("4.Start Imagination Activity");
            Console.WriteLine("5.Quit");
            Console.WriteLine("Select a choice from the menu:");
            Userinput = Console.ReadLine();

            if (Userinput == "1")
            {
                Console.Clear();
                BreathingActivity breathingActivity = new BreathingActivity();
                breathingActivity.SetNameAndDescription();
                breathingActivity.DisplayOpeningMessage();
                breathingActivity.SetUserDuration();
                breathingActivity.DisplayOpeningAnimation();
                breathingActivity.DisplayActivity();
                breathingActivity.DisplayClosingAnimation();
                breathingActivity.DispalyClosingMessage();
                breathingActivity.DisplayWaitingAnimation();
                Console.Clear();
            }

            if (Userinput == "2")
            {
                Console.Clear();
                ReflectionActivity reflectionActivity = new ReflectionActivity();
                reflectionActivity.SetNameAndDescription();
                reflectionActivity.DisplayOpeningMessage();
                reflectionActivity.SetUserDuration();
                reflectionActivity.DisplayOpeningAnimation();
                reflectionActivity.DisplayActivity();
                reflectionActivity.DisplayClosingAnimation();
                reflectionActivity.DispalyClosingMessage();
                reflectionActivity.DisplayWaitingAnimation();
                Console.Clear();
            }

            if (Userinput == "3")
            {
                Console.Clear();
                ListingActivity listingActivity = new ListingActivity();
                listingActivity.SetNameAndDescription();
                listingActivity.DisplayOpeningMessage();
                listingActivity.SetUserDuration();
                listingActivity.DisplayOpeningAnimation();
                listingActivity.DisplayActivity();
                listingActivity.DisplayClosingAnimation();
                listingActivity.DispalyClosingMessage();
                listingActivity.DisplayWaitingAnimation();
                Console.Clear();
            }

            if (Userinput == "4")
            {
                Console.Clear();
                ImaginationActivity imaginationActivityy = new ImaginationActivity();
                imaginationActivityy.SetNameAndDescription();
                imaginationActivityy.DisplayOpeningMessage();
                imaginationActivityy.SetUserDuration();
                imaginationActivityy.DisplayOpeningAnimation();
                imaginationActivityy.DisplayActivity();
                imaginationActivityy.DisplayClosingAnimation();
                imaginationActivityy.DispalyClosingMessage();
                imaginationActivityy.DisplayWaitingAnimation();
                Console.Clear();
            }

        }

    }
}