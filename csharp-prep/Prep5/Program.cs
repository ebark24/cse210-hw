using System;

class Program
{
    static void Main(string[] args)
    {
        static void display_message()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromtUserName()
        {
            Console.Write("Please enter your name:");
            string name = Console.ReadLine();
            return name;
        }
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number:");
            int User_number = int.Parse(Console.ReadLine());
            return User_number;
        }
        static int SquareNumber(int number)
        {
            int Square_number = number * number;
            return Square_number;
        }
        static void DisplayResult(string name, int square_number)
        {
            Console.WriteLine($"{name}, the square of your number is {square_number}");
        }

        display_message();
        String name = PromtUserName();
        int number = PromptUserNumber();
        int square_number = SquareNumber(number);
        DisplayResult(name, square_number);

    }
}