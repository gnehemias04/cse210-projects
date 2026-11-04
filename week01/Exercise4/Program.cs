using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        int plus = -1;
        while (plus != 0)
        {
            Console.Write("Enter number: ");
            string numberInput = Console.ReadLine();
            int number = int.Parse(numberInput);
            plus = number;
            if (number != 0)
            {
                numbers.Add(number);
            }

        }
        float total = 0;
        int largest = 0;
        foreach (int sum in numbers)
        {
            total = total + sum;
            if (largest < sum)
            {
                largest = sum;
            }

        }
        Console.WriteLine($"The sum is: {total}");
        double average = total / numbers.Count;
        Console.WriteLine($"The average is: {average}");

        Console.WriteLine($"The largest number is: {largest}");
    }
}