using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Hello Student, write hero your grade percentage: ");
        string gradePercentage = Console.ReadLine();
        float grade = float.Parse(gradePercentage);
        bool pass = true;
        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
            pass = false;
        }
        else if (grade < 60)
        {
            letter = "D";
            pass = false;
        }
        Console.WriteLine($"Your grade is: {letter}");



        if (pass == true)
        {
            Console.WriteLine("You Passed, congratulation");

        }
        else if (pass == false)
        {
            Console.WriteLine("You are not passing, try again next time");

        }

    }
}