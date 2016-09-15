using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            WineItem wine = new WineItem();
            CSVProcessor streamReader = new CSVProcessor();

            int choice = UserInterface.GetUserInput();
            switch (choice)
            {
                case 1:
                    if (streamReader == null)
                    {
                        streamReader.ImportCSV(WineItemCollection.wineItems);
                    }
                    else
                    {
                        UserInterface.Error();
                    }
                    Main(args);
                    break;
                case 2:
                    string alloutput = "";

                    foreach (WineItem wineItem in WineItemCollection.wineItems)
                    {
                        if (wineItem != null)
                        {
                            alloutput += wine.ToString() + Environment.NewLine;
                        }
                    }

                    UserInterface.PrintList(alloutput);
                    Main(args);
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    UserInterface.Pause();
                    Main(args);
                    break;
                default:
                    Console.WriteLine("Invalid Selection, Please choose from the menu below:");
                    Console.WriteLine();
                    choice = UserInterface.GetUserInput();
                    break;
            }
        }
    }
}
