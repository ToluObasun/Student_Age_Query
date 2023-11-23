using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create an array of 10 students
        string[] students = { "Tolu", "Lola", "Timi", "Nuru", "Tunji", "Paul", "Deborah", "Promise", "Mobola", "Gideon" };

        // Create a list of student ages
        List<int> studentAges = new List<int> 
        {
            17, 19, 18, 20, 21, 18, 22, 17, 19, 20 };

        // Query if a student whose age is 18 is in the list
        bool isStudentAge18 = studentAges.Contains(18);

        // Display the result
        Console.WriteLine("List of Students:");
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine("\nList of Student Ages:");
        foreach (var age in studentAges)
        {
            Console.WriteLine(age);
        }

        if (isStudentAge18)
        {
            Console.WriteLine("\nThere is a student whose age is 18 in the list.");
        }
        else
        {
            Console.WriteLine("\nThere is no student whose age is 18 in the list.");
        }

        // Wait for user input before closing the console window
        Console.ReadLine();
    }
}
