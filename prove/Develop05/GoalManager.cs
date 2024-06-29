using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    private List<Goal> _goals;
    private int _totalScore;

    // Constructor
    public GoalManager()
    {
        _goals = new List<Goal>();
        _totalScore = 0;
    }

    // Property to access goals
    public List<Goal> Goals => _goals;

    // Method to add a goal to the manager
    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    // Method to mark goal as complete
    public void RecordEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            var goal = _goals[goalIndex];
            goal.RecordEvent();

            // Update total score based on goal completion
            _totalScore += goal.IsComplete ? goal.Points : 0;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    // Method to display all goals
    public void DisplayGoals()
    {
        if (_goals.Count == 0)
        {
            Console.WriteLine("No goals to display.");
        }
        else
        {
            for (int i = 0; i < _goals.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {_goals[i].DisplayGoal()}");
            }
        }
    }

    // Method to display total score
    public void DisplayScore()
    {
        Console.WriteLine($"Total Score: {_totalScore}");
    }

    // Method to save goals to a file
    public void SaveGoals(string filePath)
    {
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            writer.WriteLine(_totalScore); // Write total score first

            foreach (var goal in _goals)
            {
                writer.WriteLine(goal.Save()); // Write each goal's save representation
            }
        }
    }

    // Method to load goals from a file
    public void LoadGoals(string filePath)
    {
        if (File.Exists(filePath))
        {
            _goals.Clear();

            using (StreamReader reader = new StreamReader(filePath))
            {
                _totalScore = int.Parse(reader.ReadLine());

                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    string type = parts[0];
                    string name = parts[1];
                    string description = parts[2];
                    int points = int.Parse(parts[3]);

                    switch (type)
                    {
                        case "SimpleGoal":
                            bool isComplete = bool.Parse(parts[4]);
                            var simpleGoal = new SimpleGoal(name, description, points);
                            if (isComplete) simpleGoal.RecordEvent();
                            _goals.Add(simpleGoal);
                            break;
                        case "EternalGoal":
                            _goals.Add(new EternalGoal(name, description, points));
                            break;
                        case "GoalChecklist":
                            int requiredCount = int.Parse(parts[4]);
                            int currentCount = int.Parse(parts[5]);
                            int bonusPoints = int.Parse(parts[6]);
                            var checklistGoal = new GoalChecklist(name, description, points, requiredCount, bonusPoints);
                            checklistGoal.CurrentCount = currentCount;
                            _goals.Add(checklistGoal);
                            break;
                        default:
                            Console.WriteLine($"Unknown goal type '{type}' in file.");
                            break;
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
}
