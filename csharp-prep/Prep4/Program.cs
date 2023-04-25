using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        int userNumber = -1;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        while (userNumber != 0)
        {
            Console.Write("Enter a number: ");
            string response = Console.ReadLine();
            userNumber = int.Parse(response);
        
            if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
        }

        //sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        //average
        float average = ((float)sum / numbers.Count);
        Console.WriteLine($"The average is: {average}");

        //max
        int max = numbers [0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}