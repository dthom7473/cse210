using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            Console.WriteLine("Please Select an Option:");
            Console.WriteLine("1 - Breathing Activity");
            Console.WriteLine("2 - Reflection Activity");
            Console.WriteLine("3 - Listing Activity");
            Console.WriteLine("4 - Quit");

            int selection;
            if (int.TryParse(Console.ReadLine(), out selection))
            {
                switch (selection)
                {
                    case 1:
                        BreathingActivity breathing = new BreathingActivity(300, "Breathing Exercise", "This activity helps you relax by focusing on your breath.");
                        await breathing.PerformActivity();
                        break;
                    case 2:
                        ReflectionActivity reflection = new ReflectionActivity(300, "Reflection Exercise", "Reflect on a personal experience and respond to uplifting questions.");
                        await reflection.PerformActivity();
                        break;
                    case 3:
                        ListingActivity listing = new ListingActivity(300, "Listing Exercise", "List as many positive things as you can think of.");
                        await listing.PerformActivity();
                        break;
                    case 4:
                        keepRunning = false;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("You must input a number.");
            }
        }
    }
}
