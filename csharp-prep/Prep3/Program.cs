using System;

int magicNumber = 50;
string userImput;
int guess;

do
{
    Console.WriteLine("what is the magic number");


    if (int.TryParse(userImput = Console.ReadLine(), out guess) && guess > magicNumber)
    {
        Console.WriteLine("lower");
    }

    else if (guess < magicNumber)
    {
        Console.WriteLine("higher");
    }
    else if (guess == magicNumber)
    {
        Console.WriteLine("Congratulatios, you guessed it!");
    }
    else
    {
        Console.WriteLine("error type");
    }
} while (magicNumber != guess);