using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment1
{
    class WineItemCollection
    {
        public static WineItem[] wineItems = new WineItem[3963];
        public WineItem wineItem = new WineItem();

        public static void Search()
        {
            Console.WriteLine("Please enter the ID of the wine you wish to find");
            string wineID = Console.ReadLine();
            for (int index = 0; index == wineItems.Length - 1; index++)
            {
                if (string.Compare(wineID, Convert.ToString(wineItems[index].ID), ignoreCase: true) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(wineItems[index].ToString());
                    Console.WriteLine();
                    return;
                }
                else
                {
                    if (string.Compare(wineID, Convert.ToString(wineItems[index].ID), ignoreCase: true) != 0)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Error: Wine not found");
                        Console.WriteLine();
                        return;
                    }
                }
            }
        }
    }
}
