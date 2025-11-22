using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        // Create instance of the goal manager file
        GoalManager manager = new GoalManager();

        bool running = true;

        // Menu for starting each activity
        while (running)
        {   
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Record Progress");
            Console.WriteLine("4. Show Score");
            Console.WriteLine("5. Save Goals");
            Console.WriteLine("6. Load Goals");
            Console.WriteLine("7. Quit");

            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // Run through the list to check which goal is wanted
                Console.WriteLine("Which type of goal?");
                Console.WriteLine("1. Simple");
                Console.WriteLine("2. Eternal");
                Console.WriteLine("3. Checklist");
                Console.Write("Type: ");
                string type = Console.ReadLine();

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Description: ");
                string desc = Console.ReadLine();

                Console.Write("Points: ");
                int points = int.Parse(Console.ReadLine());

                if (type == "1")
                {   // Call the simple goal
                    manager.AddGoal(new SimpleGoal(name, desc, points));
                }
                else if (type == "2")
                {   // Initialize the eternal goal
                    manager.AddGoal(new EternalGoal(name, desc, points));
                }
                else if (type == "3")
                {   // Initialize checklist and create a goal
                    Console.Write("Target Count: ");
                    int target = int.Parse(Console.ReadLine());

                    Console.Write("Bonus Points: ");
                    int bonus = int.Parse(Console.ReadLine());

                    manager.AddGoal(new ChecklistGoal(name, desc, points, target, bonus));
                }
                
                Console.WriteLine("Goal Created!");
            }

            else if (choice == "2")
            {   // Display the goals
                manager.DisplayGoals();
            }

            else if (choice == "3")
            { // Display the goals and pick which one completed
                manager.DisplayGoals();
                Console.Write("Which goal did you accomplish? ");
                int index = int.Parse(Console.ReadLine()) - 1;

                manager.RecordEvent(index);
            }

            else if (choice == "4")
            {
                manager.ShowScore();
            }

            else if (choice == "5")
            {
                manager.SaveGoals("goals.txt");
            }

            else if (choice == "6")
            {
                manager.LoadGoals("goals.txt");
            }

            else if (choice == "7")
            {
                running = false;
            }
        }

        
    }
}