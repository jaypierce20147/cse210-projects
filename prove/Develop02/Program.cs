using System;
using System.Xml.Linq;
using System.IO;
using System.IO.Enumeration;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Collections.Generic;


//Write a new entry
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
//Display the journal
public class FileData
{
    public string Content;
}
//Read the file
public class FileReader
{
    public static FileData ReadTextFileIntoStruct(string filepath)
    {
        //Read file content into a string then assign to struct
        FileData data = new FileData();
        data.Content = File.ReadAllText(filepath);
        return data;
    }
}

//Save the journal
public class JournalSave
{
    public void EntrySaved(string FileReceived)
    {
        string filePath = $"{FileReceived}";
        string[] newLines = {};
        File.AppendAllLines(filePath, newLines);




    }
    
}

//Load journal from file
public class Journal
{
    public List<string> Entries { get; private set; } = new List<string>();

    public void AddEntry(string entry)
    {
        Entries.Add(entry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("No entries to display.");
            return;
        }

        Console.WriteLine("\n--- Journal Entries ---");
        foreach (string entry in Entries)
        {
            Console.WriteLine(entry);
        }
        Console.WriteLine("------------------------\n");
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            Entries = File.ReadAllLines(filename).ToList();
            Console.WriteLine($"Journal loaded from '{filename}'.");
        }
        else
        {
            Console.WriteLine($"File '{filename}' not found.");
        }
    }

    public void SaveToFile(string filename)
    {
        File.WriteAllLines(filename, Entries);
        Console.WriteLine($"Journal saved to '{filename}'.");
    }
}

//Provide a menu that llows the user to choose which item to do
public class JournalMenu
{
    public void DisplayInfo()
    {
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Save");
        Console.WriteLine("4. Load");
        Console.WriteLine("5. Delete");
        Console.WriteLine("6. Quit");
        Console.WriteLine("Enter here: ");
    }
     
}

//Create prompts for the reader to choose from
public class GeneratePrompts
{
    public string GetRandomPrompt()
    {
        //This is how you store your prompts
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
        string randomPrompt = prompts[randomIndex];

        return randomPrompt;
    }
    
}





public class Program
{
    public static void Main(string[] args)
    {
        //Initiate the function
        Journal journal = new Journal();
        string currentFileName = "journal.txt"; // default filename
        //Set menu number to zero so we can enter the journal
        int menuNumber = 0;

        while (menuNumber != 6)
        {
            JournalMenu menu = new JournalMenu();
            menu.DisplayInfo();

            if (!int.TryParse(Console.ReadLine(), out menuNumber))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            if (menuNumber == 1)
            {
                JournalEntry entry = new JournalEntry();
                entry.WriteEntry(journal);
            }
            else if (menuNumber == 2)
            {
                journal.DisplayEntries();
            }
            else if (menuNumber == 3) // Save
            {
                //Initialize the Save function
                Console.Write("Enter filename to save journal: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                currentFileName = saveFile;
            }
            else if (menuNumber == 4) // Load
            {
                //Initialize the Load function
                Console.Write("Enter filename to load journal: ");
                //Read user file name
                string loadFile = Console.ReadLine();
                //Load from the file
                journal.LoadFromFile(loadFile);
                currentFileName = loadFile;
            }
            else if (menuNumber == 6)
            {
                Console.WriteLine("Exiting. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}