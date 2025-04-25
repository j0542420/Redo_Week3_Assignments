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
                Console.WriteLine("Please enter a number between 1 and 4 to get the Exercise you want to see, 5 will exit out:");
                Console.WriteLine("1. Exercise 1");
                Console.WriteLine("2. Exercise 2");
                Console.WriteLine("3. Exercise 3");
                Console.WriteLine("4. Exercise 4");
                Console.WriteLine("5. Exit");

                // space between the menu and the user input
                Console.WriteLine();

                // user inputs their choice
                int choice = Convert.ToInt32(Console.ReadLine());
                //user input uses a switch statement to determine which exercise to run
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen Exercise 1");
                        // call the method for exercise 1
                        Exercise1();
                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    case 2:
                        Console.WriteLine("You have chosen Exercise 2");
                        // call the method for exercise 1
                        Exercise2();
                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    case 3:
                        Console.WriteLine("You have chosen Exercise 3");
                        // call the method for exercise 1
                        Exercise3();
                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    case 4:
                        Console.WriteLine("You have chosen Exercise 4");
                        // call the method for exercise 1
                        Exercise4();
                        // space between the menu and the user input
                        Console.WriteLine();
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
            while (true)
            {
                // code for exercise 2
                Console.WriteLine("This is Exercise 2");
                // title for the calculator application
                Console.WriteLine("Calculator Application");

                // asking the user for input of first number 
                Console.WriteLine("What is the first number: ");
                // user inputs their first number
                double firstNumber = Convert.ToDouble(Console.ReadLine());

                // asking the user for input of second number
                Console.WriteLine("What is the second number: ");
                // user inputs their second number
                double secondNumber = Convert.ToDouble(Console.ReadLine());

                // asking the user for input of the operation
                Console.WriteLine("Select an operation");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine("5 - Exit");
                // user inputs their operation
                int choice = Convert.ToInt32(Console.ReadLine());

                // switch statement to determine which operation to perform
                switch (choice) 
                {
                    case 1:
                        // addition
                        Console.WriteLine("The result of Addition is : " + (firstNumber + secondNumber));
                        break;
                    case 2:
                        // subtraction
                        Console.WriteLine("The result of Subtraction is : " + (firstNumber - secondNumber));
                        break;
                    case 3:
                        // multiplication
                        Console.WriteLine("The result of Multiplication is : " + (firstNumber * secondNumber));
                        break;
                    case 4:
                        // division
                        if (secondNumber != 0)
                        {
                            Console.WriteLine("The result of Division is : " + (firstNumber / secondNumber));
                        }
                        else
                        {
                            Console.WriteLine("Cannot divide by zero");
                        }
                        break;
                    case 5:
                        // exit the program
                        Console.WriteLine("Exiting Calculator Application");
                        return;
                }

            }
        }
        static void Exercise3()
        {
            // code for exercise 3
            Console.WriteLine("This is Exercise 3");
            // counting the number of vowels in a string, Vowels are a, e, i, o, u
            Console.WriteLine("Please enter a string: ");
            // user inputs their string
            string input = Console.ReadLine();

            // counting the number of vowels in the string
            int count = 0;

            // string to hold the vowels
            string vowels = "aeiou";

            // loop through each character in the string
            foreach (char c in input.ToLower())
            {
                // check if the character is a vowel
                if (vowels.Contains(c))
                {
                    count++;
                }
            }

            // display the number of vowels in the string
            Console.WriteLine("The number of vowels in the string is: " + count);

        }
        static void Exercise4()
        {
            // code for exercise 4
            Console.WriteLine("This is Exercise 4");

            // the original balance of the ATM
            int balance = 1000;
            int deposit = 0;
            int withdraw = 0;

            // using while to loop through the menu
            while (true)
            {


                // Shows the menu for the ATM
                Console.WriteLine("ATM Menu");
                Console.WriteLine("1. Check Balance");
                Console.WriteLine("2. Deposit");
                Console.WriteLine("3. Withdraw");
                Console.WriteLine("4. Exit");
                // user inputs their choice
                int choice = Convert.ToInt32(Console.ReadLine());

                // switch statement to determine which operation to perform
                switch (choice)
                {
                    // user chooses to check balance
                    case 1:
                        Console.WriteLine($"Your balance is ${balance}");
                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    // user chooses to deposit
                    case 2:
                        // asking the user for input of deposit amount
                        Console.WriteLine("Enter the amount to deposit: ");
                        // user inputs their deposit amount
                        deposit = Convert.ToInt32(Console.ReadLine());

                        // shows the user their deposit was successful
                        Console.WriteLine("Deposit successful.");

                        // updating the balance
                        balance = balance + deposit;

                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    // user chooses to withdraw
                    case 3:
                        // asking the user for input of withdraw amount
                        Console.WriteLine("Enter the amount to withdraw: ");
                        // user inputs their withdraw amount
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        // checking if the withdraw amount is less than or equal to the balance
                        if (withdraw <= balance)
                        {
                            // subtracting the withdraw amount from the balance
                            balance = balance - withdraw;
                            Console.WriteLine("Withdraw successful.");
                        }
                        else
                        {
                            Console.WriteLine("Insufficient funds.");
                        }

                        // space between the menu and the user input
                        Console.WriteLine();
                        break;
                    // user chooses to exit
                    case 4:
                        Console.WriteLine("Exiting ATM.");
                        // exit the program

                        // space between the menu and the user input
                        Console.WriteLine();
                        return;
                }
            }
        }
    }
}
