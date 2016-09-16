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
            
            int choice = UserInterface.GetUserInput();
            switch (choice)
            {
                case 1:
                    if (CSVProcessor.streamReader == null)
                    {
                        CSVProcessor.ImportCSV(WineItemCollection.wineItems);
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
                            alloutput += wineItem.ToString() + Environment.NewLine;
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
                    Main(args);
                    break;
            }
        }
    }
}
