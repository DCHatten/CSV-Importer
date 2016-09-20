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
        
        public void Search()
        {
            Console.WriteLine("Please enter the ID of the wine you wish to find");
            string wineID = Console.ReadLine();
            Boolean found = false;
            for (int index = 0; index < wineItems.Length; index++)
            {
                if (string.Compare(wineID, wineItems[index].ID, true) == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(wineItems[index].ToString());
                    Console.WriteLine();
                    found = true;
                    return;
                }
            }
            if (!found)
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: Wine not found");
                    Console.WriteLine();
                    return;
            }
        }

        public void AddWineItem(string id, string description, string pack)
        {
            Array.Resize<WineItem>(ref wineItems, wineItems.Length + 1);
            wineItems[wineItems.Length - 1] = new WineItem(id, description, pack);
        }
    }
}
