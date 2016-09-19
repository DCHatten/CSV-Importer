using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    static class UserInterface
    {
        public static void GetUserInput()
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

            switch (int.Parse(input))
            {
                case 1:
                    if (CSVProcessor.streamReader == null)
                      {
                          CSVProcessor.ImportCSV(WineItemCollection.wineItems);
                      }
                    else
                    {
                        Error();
                    }
                    GetUserInput();
                    break;
                case 2:
                    string alloutput = "";

                    foreach (WineItem wineItem in WineItemCollection.wineItems)
                    {
                        if (wineItem != null)
                        {
                            alloutput += wineItem.ToString() + Environment.NewLine;
                        }
                    }

                    PrintList(alloutput);
                    GetUserInput();
                    break;
                case 3:
                    Search();
                    GetUserInput();
                    break;
                case 4:
                    break;
                case 5:
                    Pause();
                    GetUserInput();
                    break;
                default:
                    Console.WriteLine("Invalid Selection, Please choose from the menu below:");
                    Console.WriteLine();
                    GetUserInput();
                    break;
            }
        }
        public static void Search()
        {
            Console.WriteLine("Please enter the ID of the wine you wish to find");
            string wineID = Console.ReadLine();
            for (int index = 0; index == WineItemCollection.wineItems.Length - 1; index++)
            { 
                if (string.Compare(wineID, Convert.ToString(WineItemCollection.wineItems[index].ID), ignoreCase:true) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(WineItemCollection.wineItems[index].ToString());
                    Console.WriteLine();
                    return;
                }
                else
                {
                    if (string.Compare(wineID, Convert.ToString(WineItemCollection.wineItems[index].ID), ignoreCase:true) != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Error: Wine not found");
                        Console.WriteLine();
                        return;
                    }
                }
            }
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