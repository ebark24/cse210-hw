using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1,100);
        int guess = 0;
        do
        {
            Console.WriteLine("What is your guess:");
            guess = int.Parse(Console.ReadLine());
            if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }
            else if (guess == magic_number)
            {
                Console.WriteLine("That is the right number");
            }
        } while (guess != magic_number);

    }
}