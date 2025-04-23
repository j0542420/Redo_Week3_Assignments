using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Redo_Week3_Assignments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // loop through the menu until the user chooses to exit
            while (true)
            {
                // display the menu
                Console.WriteLine("Please enter a number between 1 and 4 to get the Excercise you want to see, 5 will exit out:");
                Console.WriteLine("1. Exercise 1");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. Exercise 3");
                Console.WriteLine("4. Exercise 4");
                Console.WriteLine("5. Exit");
                // user inputs their choice
                int choice = Convert.ToInt32(Console.ReadLine());
                //user input uses a switch statement to determine which exercise to run
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen Exercise 1");
                        // call the method for exercise 1
                        Exercise1();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen Exercise 2");
                        // call the method for exercise 1
                        Exercise2();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen Exercise 3");
                        // call the method for exercise 1
                        Exercise3();
                        break;
                    case 4:
                        Console.WriteLine("You have chosen Exercise 4");
                        // call the method for exercise 1
                        Exercise4();
                        break;
                    case 5:
                        Console.WriteLine("You have chosen to exit");
                        // exit the program
                        return;
                }
            }
        }
        static void Exercise1()
        {
            // code for exercise 1
            Console.WriteLine("This is Exercise 1");
            // asking the user for input of a numeric score
            Console.WriteLine("What is a numeric score (0 to 100)? ");
            // user inputs their score
            int score = Convert.ToInt32(Console.ReadLine());
            int grade = score / 10;

            // if the score is between 0 and 100, display the letter grade
            switch (grade) 
            {
                // if the score is between 90 and 100, display A
                case 10:
                case 9:
                    Console.WriteLine("Your letter grade is A");
                    break;
                // if the score is between 80 and 89, display B
                case 8:
                    Console.WriteLine("Your letter grade is B");
                    break;
                // if the score is between 70 and 79, display C
                case 7:
                    Console.WriteLine("Your letter grade is C");
                    break;
                // if the score is between 60 and 69, display D
                case 6:
                    Console.WriteLine("Your letter grade is D");
                    break;
                // if the score is between 0 and 59, display F
                case 5:
                    Console.WriteLine("Your letter grade is F");
                    break;
                // if the score is less than 0 or greater than 100, display an error message
                default:
                    Console.WriteLine("Input a score between 0 and 100");
                    break;
            }
        }
        static void Exercise2()
        {
            // code for exercise 2
            Console.WriteLine("This is Exercise 2");
            // title for the calculator application
            Console.WriteLine("Calculator Application");
            // asking the user for input of first number 
        }
        static void Exercise3()
        {
            // code for exercise 3
            Console.WriteLine("This is Exercise 3");
            // add your code here
        }
        static void Exercise4()
        {
            // code for exercise 4
            Console.WriteLine("This is Exercise 4");
            // add your code here
        }
    }
}
