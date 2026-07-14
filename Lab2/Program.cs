namespace Lab2;

using System;
/* Sergei Bazov 
It-1050 */

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Hello, World!");

    /*Task #1 Three integers and logical operation with output true or false*/
    int a = 5;
    int b = 10;
    int c = 15;
    
    Console.WriteLine("a > b:"+(a > b));
    Console.WriteLine("a < c;"+(a < c));
    Console.WriteLine("a > b && b < c:"+(a > b && b < c));
    Console.WriteLine("a > b || b < c:"+(a > b || b < c));
    // Task #2 Boolen logic adn if statment 
    bool isRaning = true;
    bool HaveUmbrella = false;
   
    if (isRaning && !HaveUmbrella)
    {
        Console.WriteLine("Take an umbrella");
    }
    else
    {
        Console.WriteLine("You're good to go!");
    }
    
    //Task #3 Age registern and tickets price 

    Console.Write("Enter your age:");
    int age = Convert.ToInt32(Console.ReadLine());

    if (age < 5)
    {
        Console.WriteLine("You are free to enter");
    }
    else if (age >= 5 && age <= 12)
    {
        Console.WriteLine("Child ticket is $5");
    }
    else if (age > 12 && age <= 64)
    {
        Console.WriteLine("Standard ticket is $10");
    }
    else if (age >= 65)
    {
        Console.WriteLine("Senior ticket is $6");
       

    }

// Task # 4 Switch statement for days of the week

    Console.Write("Enter a number (1-7) to get the corresponding day of the week:");
    int dayNumber = Convert.ToInt32(Console.ReadLine());

    switch (dayNumber)
    {
        case 1:
            Console.WriteLine("Monday");
            break;
        case 2:
            Console.WriteLine("Tuesday");
            break;
        case 3:
            Console.WriteLine("Wednesday");
            break;
        case 4:
            Console.WriteLine("Thursday");
            break;
        case 5:
            Console.WriteLine("Friday");
            break;
        case 6:
            Console.WriteLine("Saturday");
            break;
        case 7:
            Console.WriteLine("Sunday");
            break;
        default:
            Console.WriteLine("Invalid number.");
            break;
    }
    }
}

    
