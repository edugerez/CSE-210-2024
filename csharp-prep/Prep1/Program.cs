using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("What is your first name?");
        string name1 = Console.ReadLine();
        Console.WriteLine("What is your last name?");
        string lastName1 = Console.ReadLine();

        Console.WriteLine($"Your name is {lastName1}, {name1} {lastName1}.");
    }
}
