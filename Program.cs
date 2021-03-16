using System;

namespace Array_Structure_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            bool userInput = true; //declare variable 
            while (userInput) //userInput is the loop
            {
                userInput = DisplayMenu(); //calls the FDisplay menu
            }
        }
        static bool DisplayMenu()
        {
            string choose; //declare string
            System.Console.WriteLine("1: Triangle Display");
            System.Console.WriteLine("2: Numbers Table");
            System.Console.WriteLine("3: Exit");
            choose = Console.ReadLine(); 
            
            switch (choose) 
            {
                case "1": //if user chooses 1 takes them to triangle display
                    TriangleDisplay();
                    return true; //returns true to keep the while loop going
                case "2":
                    NumbersTable(); //if user chooses 2 takes them to numbers table
                    return true;
                case "3":
                    System.Console.WriteLine("Exiting Menu thanks for playing!"); //prompts user thank for playing 
                    return false; //returns false and ends menu loop
                default: 
                    System.Console.WriteLine("Not a valid choice try again!"); //tells them they made an invalid choice
                    return true; //returns to menu to make a valid choice
            }
        }
        
        static void TriangleDisplay()
        {
            int count = 10; //intitialze a variable
            int i, o, p; //declare variable for loop
            for (i = 1; i <= count; i++) //makes it so the triangle will start at 10
            {
                for (o = 1; o <= count - i; o++) //removes one from each line
                {
                    
                }
                for (p = 1; p <= o; p++) //once it hits 1 it stops
                {
                    System.Console.Write("*"); //writes the * for the triangle
                }
                System.Console.WriteLine(" "); // makes spaces between each number of *
               
            }
            
        }
        static void NumbersTable()
        {
            for (int i = 1; i < 5; i++) //makes for a row of 4
            {
                int p = 0;
                for (int o = 1; o <= 11; o++) //makes for 11 columns
                {
                    if (o == 1) 
                    {
                        System.Console.Write(i  +"\t"); // displays i and makes a tab
                    }
                    else
                    {
                        System.Console.Write((i * p) +"\t"); // multiples each row by p and makes a tab
                        p++; //p keeps going up till it hit all 4 rows and 11 columns
                    }
                }
                System.Console.WriteLine();
            }
        }

    }
}
