using System;

public class Program
{
    public static void Main(string[] args)
    {
        Journal journal = new Journal();
        string currentFileName = "journal.txt";
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
            else if (menuNumber == 3)
            {
                Console.Write("Enter filename to save journal: ");
                string saveFile = Console.ReadLine();
                journal.SaveToFile(saveFile);
                currentFileName = saveFile;
            }
            else if (menuNumber == 4)
            {
                Console.Write("Enter filename to load journal: ");
                string loadFile = Console.ReadLine();
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
