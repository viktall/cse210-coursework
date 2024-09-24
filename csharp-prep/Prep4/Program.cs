using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        
        List<int> numbersList = new List<int>();
        
        int value = -1;
        int sum = 0;
        int max = -1;
        int min = 100000000;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while(value != 0)
        {
            Console.Write("Enter number (0 to quit) : ");
            string userNum = Console.ReadLine();
            value = int.Parse(userNum);
            
            if(value != 0)
            {
                numbersList.Add(value);
            }

        }

        foreach (int digit in numbersList)
        {
            sum += digit;

            if (max < digit)
            {
                max = digit;
            }

            if (min > digit)
            {
                min = digit;
            }
        }

        float average = ((float)sum)/numbersList.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
        Console.WriteLine($"The smallest positive number is: {min}");
    }
}