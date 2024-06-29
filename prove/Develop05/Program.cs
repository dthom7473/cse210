class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        bool exitProgram = false;

        Console.WriteLine("Welcome to Eternal Quest!");

        while (!exitProgram)
        {
            Console.WriteLine();
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();
            Console.WriteLine();

            switch (input)
            {
                case "1":
                    CreateNewGoal(goalManager);
                    break;
                case "2":
                    goalManager.DisplayGoals();
                    break;
                case "3":
                    Console.Write("Enter file path to save goals: ");
                    string savePath = Console.ReadLine();
                    goalManager.SaveGoals(savePath);
                    Console.WriteLine("Goals saved successfully.");
                    break;
                case "4":
                    Console.Write("Enter file path to load goals: ");
                    string loadPath = Console.ReadLine();
                    goalManager.LoadGoals(loadPath);
                    Console.WriteLine("Goals loaded successfully.");
                    break;
                case "5":
                    RecordEvent(goalManager);
                    break;
                case "6":
                    exitProgram = true;
                    Console.WriteLine("Exiting Eternal Quest. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number from 1 to 6.");
                    break;
            }
        }
    }

    static void CreateNewGoal(GoalManager goalManager)
    {
        Console.WriteLine("Select goal type:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Enter your choice: ");

        string typeChoice = Console.ReadLine();
        Console.Write("Enter goal name: ");
        string name = Console.ReadLine();
        Console.Write("Enter goal description: ");
        string description = Console.ReadLine();
        Console.Write("Enter points for completing the goal: ");
        int points = int.Parse(Console.ReadLine());

        switch (typeChoice)
        {
            case "1":
                var simpleGoal = new SimpleGoal(name, description, points);
                goalManager.AddGoal(simpleGoal);
                break;
            case "2":
                var eternalGoal = new EternalGoal(name, description, points);
                goalManager.AddGoal(eternalGoal);
                break;
            case "3":
                Console.Write("Enter required completion count for the checklist goal: ");
                int requiredCount = int.Parse(Console.ReadLine());
                Console.Write("Enter bonus points for completing the checklist goal: ");
                int bonusPoints = int.Parse(Console.ReadLine());
                var checklistGoal = new GoalChecklist(name, description, points, requiredCount, bonusPoints);
                goalManager.AddGoal(checklistGoal);
                break;
            default:
                Console.WriteLine("Invalid choice. Goal creation canceled.");
                break;
        }
    }

    static void RecordEvent(GoalManager goalManager)
    {
        Console.WriteLine("Select goal to record event:");
        goalManager.DisplayGoals();
        Console.Write("Enter goal index: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;

        if (goalIndex >= 0 && goalIndex < goalManager.Goals.Count)
        {
            goalManager.RecordEvent(goalIndex);
            Console.WriteLine("Event recorded successfully.");
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }
}
