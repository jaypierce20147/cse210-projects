using System;

public class JournalEntry
{
    public void WriteEntry(Journal journal)
    {
        GeneratePrompts promptGenerator = new GeneratePrompts();
        string prompt = promptGenerator.GetRandomPrompt();

        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        string entry = $"Date: {DateTime.Now}\nPrompt: {prompt}\nEntry: {response}\n---------------------------";
        journal.AddEntry(entry);

        Console.WriteLine("Entry added.");
    }
}
