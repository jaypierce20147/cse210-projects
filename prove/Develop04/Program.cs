using System;
using System.Diagnostics;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Breathing");
            Console.WriteLine("  2. Reflection");
            Console.WriteLine("  3. Listing");
            Console.WriteLine("  4. Quit");

            Console.Write("\nSelect a choice: ");
            string? choice = Console.ReadLine();

            if (choice == "1")
            {
                Breathing activity = new Breathing();
                activity.Run();
            }
            else if (choice == "2")
            {
                Reflection activity = new Reflection();
                activity.Run();
            }
            else if (choice == "3")
            {
                Listing activity = new Listing();
                activity.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("Goodbye!");
                return;
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to try again.");
                Console.ReadLine();
            }

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }

    }
}