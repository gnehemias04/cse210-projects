using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();




    public PromptGenerator()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What makes you feel peaceful?");
        _prompts.Add("What is one thing you would like to learn?");
        _prompts.Add("What is a memory that always makes you smile?");
        _prompts.Add("What is something you are looking forward to?");
        _prompts.Add("When was the last time you helped someone?");
        _prompts.Add("What is one decision that changed your life?");
        _prompts.Add("What would you do if you knew you could not fail?");
        _prompts.Add("What is something you take for granted?");
        _prompts.Add("What makes a person a good friend?");
        _prompts.Add("What is one habit you would like to develop?");
        _prompts.Add("What did you learn from a recent mistake?");
        _prompts.Add("Where do you see yourself in five years?");
        _prompts.Add("What is something that makes you feel proud?");
        _prompts.Add("If you could travel anywhere, where would you go?");
        _prompts.Add("What is one thing you could do tomorrow to make it a better day?");

    }
    public string GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int indexRandom = randomGenerator.Next(0, _prompts.Count);

        string prompt;
        prompt = _prompts[indexRandom];
        return prompt;

    }
}