using System;
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    // Constructor: runs automatically when you do "new PromptGenerator()"
    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("What was the most scary thing that happened today?");
        _prompts.Add("What made you feel nervous today?");
        _prompts.Add("Is there anything you did today that you'd like to try again?");
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(0, _prompts.Count);
        return _prompts[index];
    }
}
