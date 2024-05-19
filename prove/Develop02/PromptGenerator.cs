using System;
using System.Linq;
using System.Collections.Generic;



public class PromptGenerator
{
    public List<string> _prompts = new List<string>();


    public string GetRandomPrompt()
    {
        _prompts.Add("lo mejor de hoy");
        _prompts.Add("lo peor de hoy");
        _prompts.Add("lo mas loco de hoy");
        _prompts.Add("lo mas interesante de hoy");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0, 4);
        return _prompts[number];


    }
}