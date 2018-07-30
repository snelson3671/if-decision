using System;

namespace if_decision
{
    class Program
    {
        static void Main(string[] args)
        {
            // This writes the first line on the console, then jumps to the next line
            Console.WriteLine("Sandra's Monthly Helper");
            Console.WriteLine("Type any number from 1 to 12");
            // This writes the second line on the console, but does not jump to the next line
            Console.Write("I will tell you which month corresponds to that number! ");
            
            // This declares the variable userValue as a string and causes the code to wait for user input
            string userValue = Console.ReadLine();
            // This declares the variable message as a string and assigns whatever string is between the quotes later
            string message = "";

            // This evaluates whether or not the userValue is 1. 
            // If it is, then the program writes January in the console.
            // If not, the program moves to the next line
            if (userValue == "1")
                message = "January";
           
            // The following lines evaluate whether or not the userValue is a certain number.
            // If it is, then the program writes the corresponding month in the console.
            // If not, the program moves to the next line
            else if (userValue == "2")
                message = "February";
            else if (userValue == "3")
                message = "March";
            else if (userValue == "4")
                message = "April";
            else if (userValue == "5")
                message = "May";
            else if (userValue == "6")
                message = "June";
            else if (userValue == "7")
                message = "July";
            else if (userValue == "8")
                message = "August";
            else if (userValue == "9")
                message = "September";
            else if (userValue == "10")
                message = "October";
            else if (userValue == "11")
                message = "November";
            else if (userValue == "12")
                message = "December";

            // If the user types anything other than a number from 1 to 12
            // then program writes the following message in the console.
            else message = "I don't understand.  Please type a number from 1 to 12.";

            // This writes the string associated with the userValue
            Console.WriteLine(message);
            // This pauses the program so the user can read the message
            Console.ReadLine();
        }
    }
}
