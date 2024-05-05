using System;
using System.Linq;

namespace Prep5;

public static class Program
{
    public static void Main()
    {

        DisplayWelcome();
        string name = PromptUserName();
        int userNumber = PromptUserNumber();
        int square = SquareNumber(userNumber);
        DisplayResult(name, square);




        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program");

        }


        static string PromptUserName()
        {
            Console.WriteLine("Please enter you name ");
            string name = Console.ReadLine();
            return name;

        }

        static int PromptUserNumber()
        {
            Console.WriteLine("enter your favorite number! ");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            return userNumber;
        }

        static int SquareNumber(int userNumber)
        {
            int square = (userNumber * userNumber);
            return square;
        }

        static void DisplayResult(string name, int square)
        {
            Console.WriteLine(name + ", the square of your favorite number is: " + square);


        }



    }
}