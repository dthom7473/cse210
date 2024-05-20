using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?: ");
        string gradeString = Console.ReadLine();
        int gradePercentage = int.Parse(gradeString);

        string letterGrade;
        letterGrade = "F";
        bool passed = false;

        if (gradePercentage >= 90) {
            letterGrade = "A";
            passed = true;
        }
        else if (gradePercentage >= 80 && gradePercentage < 90){
            letterGrade = "B";
            passed = true;
        }
        else if (gradePercentage >= 70 && gradePercentage < 80){
            letterGrade = "C";
            passed = true;
        }
        else if (gradePercentage >= 60 && gradePercentage < 70){
            letterGrade = "D";
            passed = false;
        }
        else if (gradePercentage < 60){
            letterGrade = "F";
            passed = false;
        }
        Console.WriteLine($"Your letter grade is {letterGrade}");
        if (passed) {
        Console.WriteLine("You have passed the class");
        }
        else{
            Console.WriteLine("You have not passed the class");
        }
        
    }
} 