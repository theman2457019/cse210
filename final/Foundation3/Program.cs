using System;

class Program
{
    static void Main(string[] args)
    {
        Lecture lecture = new Lecture(
            "2070 Paradigm Shift",
            "A Lecture on the future of technology and society.",
            "April 15, 2025",
            "10:00 AM",
            new Address("456 Urmom way", "Seattle", "WA", "98101"),
            "Mr. Sam Hyde",
            200000
        );

        Reception reception = new Reception(
            "Graduation Reception",
            "Celebration of student achievements with luncheon and music.",
            "May 10, 2025",
            "6:00 PM",
            new Address("123 Example St", "Rexburg", "ID", "83440"),
            "rsvp@companygala.com"
        );

        OutdoorGathering outdoor = new OutdoorGathering(
            "Community Picnic",
            "A fun gathering with food and games in the park.",
            "June 1, 2025",
            "1:00 PM",
            new Address("Mccowan Park", "Idaho Falls", "ID", "83401"),
            "Sunny with a high of 75°F"
        );

        List<Event> events = new List<Event> { lecture, reception, outdoor };


        foreach (Event ev in events)
        {
            Console.WriteLine("=== Standard Details ===");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("=== Full Details ===");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("=== Short Description ===");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine(new string('-', 40));
        }
    }
}