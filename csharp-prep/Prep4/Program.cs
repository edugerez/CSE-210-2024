using System;
using System.Linq;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("enter a number!");
        string inputUser = Console.ReadLine();
        List<int> numbers = new List<int>();
        int totalSum = 0;



        while (inputUser != "0")
        {

            int userN = int.Parse(inputUser);
            numbers.Add(userN);
            Console.WriteLine("enter another number");
            inputUser = Console.ReadLine();
            totalSum = totalSum + userN;

            if (inputUser == "0")
            {
                Console.WriteLine("thanks");
                foreach (int number in numbers)
                {

                }

            }
        }
        Console.WriteLine($" the sum of these are: {totalSum}");
        Console.WriteLine($" the average of these are: {totalSum / numbers.Count}");
        Console.WriteLine($" the largest number of these are: {numbers.Max()}");
    }



}
