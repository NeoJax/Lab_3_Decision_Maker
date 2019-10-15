// ===============================
// AUTHOR     : Jonathan Lubaway
// CREATE DATE: October 15th, 2019
// PURPOSE    : Use conditional statements to automate the decision-making process
// ===============================

using System;

namespace Lab_3_Decision_Maker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompt and receive the user's name also setting up the while loop for the program
            Console.WriteLine("Please enter your name.");
            string userName = Console.ReadLine();
            bool moreNumbers = true;
            while (moreNumbers)
            {
                // Prompt and receive the user's number while making sure it is between the criteria
                bool fits = false;
                int userInput = 0;
                while (!fits)
                {
                    Console.WriteLine("Hello, " + userName + ". Please enter a number between 1 and 100. Also enter -1 to close the program.");
                    userInput = int.Parse(Console.ReadLine());
                    if (!(0 < userInput) && !(userInput < 101))
                    {
                        fits = false;
                        Console.WriteLine(userName + ", your number does not fit within the given criteria.");
                    }
                    else if (userInput == -1)
                    {
                        moreNumbers = false;
                    }
                    else
                    {
                        fits = true;
                    }
                }
                string decision = userInput + "";

                // Make a decision based on if statements
                if (userInput % 2 == 0)
                {
                    if (userInput <= 25)
                    {
                        Console.WriteLine(userName + " your number is even and less than 25");
                    }
                    else if (userInput <= 60)
                    {
                        Console.WriteLine(userName + " your number is even");
                    }
                    else
                    {
                        Console.WriteLine(userName + " your number is " + userInput + " and is even");
                    }
                }
                else if (userInput % 2 != 0)
                {
                    if (userInput <= 60)
                    {
                        Console.WriteLine(userName + " your number is " + userInput + " and is odd");
                    }
                    else
                    {
                        Console.WriteLine(userName + " your number is odd and is greater than 60");
                    }
                }
            }
        }
    }
}
