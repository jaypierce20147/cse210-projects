using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("123 Maple St", "Phoenix", "AZ");
        Address a2 = new Address("55 Ocean Ave", "Miami", "FL");
        Address a3 = new Address("22 Forest Trail", "Portland", "OR");

        Lecture lecture = new Lecture(
            "AI in 2025",
            "Deep dive into artificial intelligence",
            "04/20/2025",
            "7:00 PM",
            a1,
            "Dr. Jane Smith",
            150
        );

        Reception reception = new Reception(
            "Business Networking",
            "Meet professionals and expand your circle",
            "05/10/2025",
            "6:00 PM",
            a2,
            "rsvp@event.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Summer Festival",
            "Music, games and food!",
            "06/15/2025",
            "11:00 AM",
            a3,
            "Sunny & warm"
        );

        // LECTURE
        Console.WriteLine("\n=== LECTURE ===");
        Console.WriteLine(lecture.GetFullDetails(lecture.GetLectureDetails()));
        Console.WriteLine(lecture.GetShortDescription());

        // RECEPTION
        Console.WriteLine("\n=== RECEPTION ===");
        Console.WriteLine(reception.GetFullDetails(reception.GetReceptionDetails()));
        Console.WriteLine(reception.GetShortDescription());

        // OUTDOOR
        Console.WriteLine("\n=== OUTDOOR EVENT ===");
        Console.WriteLine(outdoor.GetFullDetails(outdoor.GetOutdoorDetails()));
        Console.WriteLine(outdoor.GetShortDescription());
    }
}