using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            string modeOfTransportation = " ";//declaring an empty string the value of which is going to be changed later in the code
            int yearsUntilRetirement;
            string vacationHome = " ";
            double money;
            string color = " ";

            //Asking a user for input and storing all the values in different variables
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your birth month:");
            int birthMonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Select your color from ROYGBIV list:");
            Console.WriteLine("(type 'Help' to see the list of ROYGBIV colors)");

            string usersChoice = Console.ReadLine().ToLower();
            if (usersChoice=="help")//if a user asks for help the program will show the menu with the list of colors and asks for a color again
            {
                Console.WriteLine("Red, Orange, Yellow, Green, Blue, Indigo, Violet.");
                Console.WriteLine("Select your color from ROYGBIV list:");
                color = Console.ReadLine();
            }
            else//if a user doesn't ask for help, the input will be saved as a color
            {
                color = usersChoice;
            }

            /*The variable 'car' gets a different value 
            depending on the color user picks*/
            switch (color.ToLower())
            {
                case "red":
                    modeOfTransportation = "red bike";
                    break;
                case "orange":
                    modeOfTransportation = "orange bike";
                    break;
                case "yellow":
                    modeOfTransportation = "yellow bike";
                    break;
                case "green":
                    modeOfTransportation = "green bike";
                    break;
                case "blue":
                    modeOfTransportation = "blue bike";
                    break;
                case "indigo":
                    modeOfTransportation = "indigo bike";
                    break;
                case "violet":
                    modeOfTransportation = "violet bike";
                    break;
                default://if a user fails to pick a color from the list
                    modeOfTransportation = "broken bike";
                    Console.WriteLine("You failed to pick the color...");
                    break;
            }


            /*The variable 'yearsUntilRetirement' gets a different value 
            depending on the age user inputs*/
            if (age % 2 == 0) //this line checks wether age is even
            {
                yearsUntilRetirement = age * 2;
            }
            else //if the value of age isn't even that this piece of code is executed
            {
                yearsUntilRetirement = age - 2;
            }


            Console.WriteLine("Enter the number of siblings:");
            int numberOfSiblings = int.Parse(Console.ReadLine());


            /*The variable 'vacationHome' gets a different value 
            depending on the number of siblings user inputs*/
            if (numberOfSiblings > 3)
            {
                vacationHome = "super huge house";
            }
            else if (numberOfSiblings == 3)
            {
                vacationHome = "huge house";
            }
            else if (numberOfSiblings == 2)
            {
                vacationHome = "big house";
            }
            else if (numberOfSiblings == 1)
            {
                vacationHome = "normal house";
            }
            else if (numberOfSiblings == 0)
            {
                vacationHome = "little house";
            }


            /*The variable 'money' gets a different value 
            depending on the birth of month user inputs*/
            if (birthMonth >= 1 && birthMonth <= 4)
            {
                money = birthMonth * 150 / 0.2;
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                money = birthMonth * 0 + 17;
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                money = (birthMonth + 1500)/2;
            }
            else
            {
                money = 0.00;
            }

            //Output
            Console.WriteLine("{0} {1} will retire in {2} year(s) with ${3} in the bank,\n a vacation home in a {4}, and a(n) {5}.", firstName, lastName, yearsUntilRetirement, money, vacationHome, modeOfTransportation);

        }
    }
}
