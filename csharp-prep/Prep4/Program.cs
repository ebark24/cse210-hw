using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 10;
        List<int> numbers = new List<int>();
        while (number != 0)
        {
            Console.WriteLine("Enter number: ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numbers)
        {
            sum = sum + num;
        }
        Console.WriteLine(sum);

        int average = sum / numbers.Count();
        Console.WriteLine(average);

        int large_number = 0;
        foreach (int numb in numbers)
        {
            if (numb > large_number)
            {
                large_number = numb;
            }
        }
        Console.WriteLine(large_number);




    }
}