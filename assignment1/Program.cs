using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class Program
    {
        public static WineItem[] wineItems = new WineItem[3963];
        public static WineItemCollection wineItemCollection = new WineItemCollection();
        static void Main(string[] args)
        {
            Console.WindowWidth = 88;
            int selection;
            string id = "";
            string description = "";
            string pack = "";
            UserInterface.GetUserInput(out selection);

            switch (selection)
            {
                case 1:
                    if (CSVProcessor.streamReader == null)
                    {
                        CSVProcessor.ImportCSV();
                    }
                    else
                    {
                        UserInterface.Error();
                    }
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
                    break;
                case 3:
                    wineItemCollection.Search();
                    break;
                case 4:
                    UserInterface.AddItem(out id, out description, out pack);
                    wineItemCollection.AddWineItem(id, description, pack);
                    break;
                case 5:
                    UserInterface.Pause();
                    break;
                default:
                    Console.WriteLine("Invalid Selection, Please choose from the menu below:");
                    Console.WriteLine();
                    break;
            }
            Main(args);
        }
    }
}
