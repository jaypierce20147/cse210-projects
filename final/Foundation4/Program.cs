using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        activities.Add(new Running("03 Nov 2022", 30, 3f));
        activities.Add(new Cycling("05 Nov 2022", 45, 15f));
        activities.Add(new Swimming("10 Nov 2022", 25, 20));

        foreach (Activity a in activities)
        {
            Console.WriteLine(a.GetSummary());
        }
    }
}