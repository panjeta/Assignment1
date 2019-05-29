

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    class Program
    {
        public static int ValidationMenuSelection()
        {
            string userInput = "";
            bool validMenuSelect = false;

            while (validMenuSelect == false)
            {
                Console.WriteLine("1 = Get Rectangle Length");
                Console.WriteLine("2 = Change Rectangle lenght");
                Console.WriteLine("3 = Get Rectangle Width");
                Console.WriteLine("4 = Change Rectangle Width");
                Console.WriteLine("5 = Get Rectangle Permeter");
                Console.WriteLine("6 = Get Rectangle Area");
                Console.WriteLine("7 = Exit\n");

                Console.WriteLine("Please select an option, by entering a number:\n");
                userInput = Console.ReadLine();

                if (userInput != "1" &&
                    userInput != "2" &&
                    userInput != "3" &&
                    userInput != "4" &&
                    userInput != "5" &&
                    userInput != "6" &&
                    userInput != "7")
                {
                    Console.WriteLine("That's not a valid menu option, Please Try again: \n");
                }
                else
                {
                    validMenuSelect = true;
                }
            }
            Console.WriteLine();
            return int.Parse(userInput);
        }

        public static int ValidateUserInput(string rectSide)
        {
            int number = 1;
            bool isValid = false;

            while (isValid == false)
            {
                Console.WriteLine($"Please enter the {rectSide} of your rectangle:");
                string userInput = Console.ReadLine();
                Console.WriteLine();
                bool result = int.TryParse(userInput, out number);
                if (result == false)
                {
                    Console.WriteLine("That's not a valid input, please try again.\n");
                }
                else if (number <= 0)
                {
                    Console.WriteLine("Number must be greater then zero");
                }
                else if (number > 0)
                {
                    isValid = true;
                    Console.WriteLine($"The {rectSide} of your rectangle is now {number}\n");

                }
            }
            return number;
        }
        static void Main(string[] args)
        {
            Rectangle c = new Rectangle();
            bool validCalcSelect = false;
            string calcSelection;
            int selection;

            while (validCalcSelect == false)
            {
                Console.WriteLine("1 = Use default values of length=1 and width=1\n");
                Console.WriteLine("2 = Provide your own length and width\n");
                Console.WriteLine("Choose a menu item to begin:");
                calcSelection = Console.ReadLine();
                Console.WriteLine();

                if (calcSelection != "1" && calcSelection != "2")
                {
                    Console.WriteLine("That's not a valid selection, please try again.\n");
                }
                else if (int.Parse(calcSelection) == 1)
                {
                    validCalcSelect = true;
                    Random random = new Random();
                    int length = 1;
                    int width = 1;

                    Console.WriteLine($"Your default length is {length} and width is {width}.\n");
                    Rectangle customCalc = new Rectangle(length, width);
                    c = customCalc;

                }
                else if (int.Parse(calcSelection) == 2)
                {
                    validCalcSelect = true;

                    int length;
                    int width;

                    length = ValidateUserInput("length");
                    width = ValidateUserInput("width");

                    Console.WriteLine($"Your custom length is {length} and width is {width}.\n");
                    Rectangle customCalc = new Rectangle(length, width);
                    c = customCalc;
                }
            }


            selection = ValidationMenuSelection();

            while (selection != 7)
            {
                int result;

                switch (selection)
                {
                    case 1:
                        Console.WriteLine($"Length is: {c.GetLength()}\n");
                        break;
                    case 2:
                        result = ValidateUserInput("length");
                        c.SetLength(result);
                        break;
                    case 3:
                        Console.WriteLine($"Width is: {c.GetWidth()}\n");
                        break;
                    case 4:
                        result = ValidateUserInput("width");
                        c.SetWidth(result);
                        break;
                    case 5:
                        Console.WriteLine($"The Perimeter of {c.GetLength()} and {c.GetWidth()} is: {c.GetPerimeter()}\n");
                        break;
                    case 6:
                        Console.WriteLine($"The Area of {c.GetLength()} and {c.GetWidth()} is:{c.GetArea()}\n");
                        break;
                    default:
                        break;
                }

                selection = ValidationMenuSelection();

            }

        }

    }
}

