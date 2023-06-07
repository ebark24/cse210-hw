using System;

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathingActivity = new BreathingActivity();
        breathingActivity.SetNameAndDescription();
        breathingActivity.DisplayOpeningMessage();
        breathingActivity.SetUserDuration();
        breathingActivity.DisplayOpeningAnimation();
        breathingActivity.DisplayActivity();
        breathingActivity.DisplayClosingAnimation();
        breathingActivity.DispalyClosingMessage();
    }
}