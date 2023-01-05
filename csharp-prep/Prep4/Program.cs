using System;

class Program
{
    static void Main(string[] args)
    {
        // Enter a list of numbers, type 0 when finished.
        // Enter number: 18
        // Enter number: 36
        // Enter number: 2
        // Enter number: 48
        // Enter number: 6
        // Enter number: 12
        // Enter number: 9
        // Enter number: 0
        // The sum is: 131
        // The average is: 18.714285714285715
        // The largest number is: 48

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        // Create the list
        List<int> numbers = new List<int>();

        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            
            string userResponse = Console.ReadLine();
            userNumber = int.Parse(userResponse);
            
            // Only add the number to the list if it is not 0
            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        // Compute the Sum
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        // Compute the Average
        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the max 
        int max = numbers[0];

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