namespace Lab3;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    // Problem #1.Simple  for loop to print numbers from 1 to 10
    Console.WriteLine("Problem #1");
    for (int i = 1; i <= 10; i++)
    {
        Console.WriteLine(i);
    }

    // Problem #2. Simple for loop to print even numbers from 1 to 20
    Console.WriteLine("Problem #2");
    for (int i = 1; i <= 20; i++)
    {
        if (i % 2 == 0)
        {
            Console.WriteLine(i);               
        }
    }
    // Problem #3 While Loop Countdown 
    Console.WriteLine("Problem #3");
    int countdown = 5;
    while (countdown >=1)
    {
        Console.WriteLine(countdown);
        countdown--;
    }
    // Problem #4 Mulitiple of 10 to 1000
    Console.WriteLine("Problem #4");
    int number = 10;
    while (number <= 1000)
    {
        Console.WriteLine(number);
        number += 10;   
    }
    //Problem #5. Season of the year 
    Console.WriteLine("Problem #5");
    string[] seasons = { "Winter", "Spring", "Summer", "Fall" };
    foreach (string season in seasons)
        {
            Console.WriteLine(season);
        }
        // Problem #6. Days of the week 
        Console.WriteLine("Problem #6");
        string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday",
         "Friday", "Saturday", "Sunday" };
        Console.Write("Enter a number between 1 and 7:");
        int dayNumber = Convert.ToInt32(Console.ReadLine());
        if (dayNumber >= 1 && dayNumber <= 7)
        {
            Console.WriteLine(daysOfWeek[dayNumber - 1]);

        }
        else 
        {
            Console.WriteLine("Invalid input.");

        }

        // Problem #7. Fovarite Books and Authors
        Console.WriteLine("Problem #7");
        string[] books = { "The Great Gatsby", "To Kill a Mockingbird", "Harry Potter" };
        string[] authors = { "F. Scott Fitzgerald", "Harper Lee", "J.K. Rowling" };

        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine($"{books[i]} by {authors[i]}");

        }
        // Problem #8. Temprerature Tracker 
        Console.WriteLine("Problem #8");
        int[] temperatures = { 72, 65, 80, 60,75 };

        Array.Sort(temperatures);
        Console.WriteLine("Temperatures in ascending order:");
        foreach (int temp in temperatures)
        {
            Console.WriteLine(temp);
        }
       Console.WriteLine("Lowest temperature: " + temperatures[0]);
       Console.WriteLine("Highest temperature: " + temperatures[temperatures.Length - 1]);

        // Problem #9. Reverse Countdown
        Console.WriteLine("Problem #9");
        int[] reverseCountdown = { 5, 4, 3, 2, 1 };
        Array.Reverse(reverseCountdown);
        for (int i = 0; i < reverseCountdown.Length; i++)
        {
            Console.WriteLine(reverseCountdown[i]);
        }
    }
}

