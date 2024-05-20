using System.ComponentModel.DataAnnotations;

class Course {
    public string _courseCode;
    
    public string _className;
    public int _numberOfCredits;

    public string _color;


    //method
    public void Display()
    {
        Course course1 = new Course();
        course1._className = "Programming with Classes";
        course1._color = "green";
        course1._courseCode = "CSE 210";
        course1._numberOfCredits = 2;
        course1.Display();
    }
}