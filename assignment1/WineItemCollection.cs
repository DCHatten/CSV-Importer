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
            UserInterface.SearchPrompt();
            string wineID = Console.ReadLine();
            foreach (WineItem wineItem in wineItems)
            {
                //if (string.Compare(wineID, ) == true)
                //{
                //    Console.WriteLine(ToString());
                //}
            }
        }

        public override string ToString()
        {
            return wineItem.ID + "  " + wineItem.Description + "  " + wineItem.Pack;
        }
        public string StringSearch()
        {
            return wineItem.ID;
        }
    }
}
