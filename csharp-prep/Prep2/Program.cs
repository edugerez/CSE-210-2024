using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Tell me you grade porcentage");
        string userAnswer = Console.ReadLine();



        if (int.TryParse(userAnswer, out int grade) && grade < 60)
        {
            Console.WriteLine("your grade is F, keep trying!");
        }

        else if (grade >= 60 && grade < 70)
        {
            Console.WriteLine("your grade is D, keep trying!");

        }

        else if (grade >= 70 && grade < 80)
        {
            Console.WriteLine("your grade is C, CONGRATS!");

        }

        else if (grade >= 80 && grade < 90)
        {
            Console.WriteLine("your grade is B, CONGRATS!");

        }
        else if (grade >= 90)
        {
            Console.WriteLine("your grade is A, CONGRATS!");

        }

        else
        {
            Console.WriteLine("error type o invalid data");
        }


    }
}