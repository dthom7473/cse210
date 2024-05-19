using System;

class Program
    static void Main(string[] args)
{

    int x = 0; //you should normally give variables a starting value

    if (x==0){
        //do some fun stuff here
        Console.WriteLine("TEXT");
    }

    while (x < 3) {
        Console.WriteLine("TEXT");
        x = x + 1; //can also use x += 1
    }

    do {
        Console.WriteLine("TEXT");

    } while (x < 3); //this gaurentees that the code will run at least once

    foreach (x in something) {
        //insert fun code
    }

    for (int x = 0; x < 9; x++) { //(initializer; true/false test; modifier)
        Console.WriteLine("TEXT");
    }
}