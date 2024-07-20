class Program
{
    static void Main(string[] args)
    {
        var address1 = new Address("945 Barkstone Ct", "Salem", "Oregon", "97306", "USA");
        var address2 = new Address("5863 N Arliss Ave", "Fort Frances", "Ontario", "P9A", "Canada");
        var address3 = new Address ("Hogwarts Castle", "Highlands","Scotland", "Great", "Britain");

        var lecture = new Lecture("Ted Talk", "A short but powerful talk about Ted (we gotta do something about that man)", "15 June, 2025", "6:00 PM", address1, "Not Ted", 500);
        var reception = new Reception("The Jones' Marraige Reception", "Join us as we celebrate the recent sealing of the Jones'!", "December 12, 2024", "3:00 PM", address2, "don'temailme@gmail.com");
        var party = new Party("Nearly Headless Nick's Deathday Party", "Join us in celebration of the death day of Sir Nicholas de Mimsy-Porpington who died on the 31st of October, 1492 (fresh food not provided).", "31 October, 2024", "8:00 PM", address3, "Clear");

        var events = new List<Event> {lecture, reception, party};

        foreach (var ev in events)
        {
            Console.WriteLine($"\nEvent Type: {ev.GetType().Name}\n");
            Console.WriteLine($"Standard Details:\n {ev.GetStandardDetails()}\n");
            Console.WriteLine($"Full Details:\n {ev.GetFullDetails()}\n");
            Console.WriteLine($"Short Details: {ev.GetShortDetails()}\n");
        }

    }
}