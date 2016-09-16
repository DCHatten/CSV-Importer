using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class UserInterface
    {
        public static int GetUserInput()
        {
            printMenu();

            string input = Console.ReadLine();

            while (input != "1" && input != "2" && input != "3" && input != "4" && input != "5")
            {
                Console.WriteLine("Invalid Selection, Please choose from the menu below:");
                Console.WriteLine();
                printMenu();
                input = Console.ReadLine();
            }

            return int.Parse(input);
        }
        public static void SearchPrompt()
        {
            Console.WriteLine("Please enter the ID of the wine you wish to find");
        }
        public static void Pause()
        {
            Console.WriteLine("Are you sure you wish to exit?");
            Console.WriteLine("\tY or N");
            string input = Console.ReadLine();
            if (input == "Y" || input == "y")
            {
                Environment.Exit(0);
            }
            else
            {
                return;
            }
        }

        public static void PrintList(string fullList)
        {
            Console.WriteLine(fullList);
        }

        public static void Error()
        {
            Console.WriteLine("The file has already been loaded");
            Console.WriteLine();
        }
        private static void printMenu()
        {
            Console.WriteLine("Please choose what you would like to do:");
            Console.WriteLine("1. Load the current Wine List");
            Console.WriteLine("2. Display the current Wine List");
            Console.WriteLine("3. Search for a Wine by ID");
            Console.WriteLine("4. Add a new Wine to the Wine List");
            Console.WriteLine("5. Exit");
        }
    }
}
