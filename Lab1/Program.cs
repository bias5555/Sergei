using System;

class Program
{
    /*
     Name:Sergei Bazov 
     Title: IT-1050 - Lab 1
    */

    static void Main(string[] args)
    {
        // Step 2 
        Console.WriteLine("Name: Your Name");
        Console.WriteLine("Course: IT-1050 - Lab 1");

        // Step 3 list of favorite things in different format and print
        int favoriteNumber = 1277;
        string favoriteLanguage = "HTML";
        double programsWritten = 0;
        bool programmingExperience = false;

        Console.WriteLine("Favorite Number: " + favoriteNumber);
        Console.WriteLine("Favorite Programming Language: " + favoriteLanguage);
        Console.WriteLine("Programs Written Before This: " + programsWritten);
        Console.WriteLine("Programming Experience: " + programmingExperience);

        // Step 4 create a constant and display it 
        const string schoolName = "Cuyahoga Community College";
        Console.WriteLine("School: " + schoolName);

        // Step 5 double and convert and print
        double doubleValue = 9.78;
        int intValue = (int)doubleValue;

        string intString = Convert.ToString(intValue);
        string boolString = Convert.ToString(programmingExperience);

        Console.WriteLine("Double: " + doubleValue);
        Console.WriteLine("Int (cast): " + intValue);
        Console.WriteLine("Int as String: " + intString);
        Console.WriteLine("Bool as String: " + boolString);

        // Step 6 input and output print 
        Console.Write("Enter your name: ");
        string userName = Console.ReadLine();

        Console.Write("Enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Hello " + userName + "! You are " + age + " years old.");

        // Step 7 basic math operations 
        int num1 = 20;
        int num2 = 5;

        Console.WriteLine("Addition (num1 + 10): " + (num1 + 10));
        Console.WriteLine("Subtraction (num1 - 2): " + (num1 - 2));
        Console.WriteLine("Multiplication (num2 * 3): " + (num2 * 3));
        Console.WriteLine("Division (num1 / 2): " + (num1 / 2));
        Console.WriteLine("Modulus (num1 % 2): " + (num1 % 2));

        // Step 8 flaot and double,difference detween 
        float floatValue = 1.123456789f;
        double preciseDouble = 1.123456789;

        Console.WriteLine("Float: " + floatValue);
        Console.WriteLine("Double: " + preciseDouble);
        Console.WriteLine("Notice that the double keeps more decimal precision than the float.");

        // Step 9 -- and + 
        int number = 10;

        number++;
        Console.WriteLine("After increment: " + number);

        number--;
        Console.WriteLine("After decrement: " + number);
    }
}