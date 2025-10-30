using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage? ");
        string grade = Console.ReadLine();
        int grade_int = int.Parse(grade);

        string letter = "";

        if (grade_int >= 90)
        {
            letter = "A";
        }
        else if (grade_int >= 80)
        {
            letter = "B";
        }
        else if (grade_int >= 70)
        {
            letter = "C";
        }
        else if (grade_int >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your final grade is {letter}.");

        if (grade_int >= 70)
        {
            Console.WriteLine("Congratulations, you passed the course. ");
        }
        else
        {
            Console.WriteLine("Better luck next time. ");
        }
    }
}