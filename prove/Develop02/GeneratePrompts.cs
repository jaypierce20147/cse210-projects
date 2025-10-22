using System;
using System.Collections.Generic;

public class GeneratePrompts
{
    public string GetRandomPrompt()
    {
        List<string> prompts = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
            "Did you make any new friends today, if so who? What were they like?",
            "Did you talk to your parents today, if not when are you going to?",
            "Did you learn anything new today, if so, what? If not, why not?",
        };

        if (prompts.Count == 0)
        {
            return "No prompts allowed at this time.";
        }

        Random random = new Random();
        int randomIndex = random.Next(prompts.Count);
        return prompts[randomIndex];
    }
}
